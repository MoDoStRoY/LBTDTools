var path = require('path');
var webpack = require('webpack');
var pluginExtractText = require('mini-css-extract-plugin');
var pluginUglifyJS = require('uglifyjs-webpack-plugin');

module.exports = function(env) {
    var isDevBuild = !(env && env.prod);
    var devMode = isDevBuild ? 'development':'production';

    return [{
        mode: devMode,
        stats: { modules: false },
        resolve: { extensions: [ '.js' ] },
        entry: {
            vendor: [
                'event-source-polyfill',
                'isomorphic-fetch',
                'vue',
                'vue-router',
                'vuelidate',
                'universal-cookie',
                'buefy/dist/buefy.css'
            ]
        },
        module: {
            rules: [
                { test: /\.css(\?|$)/, use: [pluginExtractText.loader, 'css-loader'] },
                { test: /\.(png|woff|woff2|eot|ttf|svg)(\?|$)/, use: 'url-loader?limit=100000' }
            ]
        },
        output: {
            path: path.join(__dirname, 'wwwroot', 'dist'),
            publicPath: 'dist/',
            filename: '[name].js',
            library: '[name]_[hash]'
        },
        plugins: [
            new pluginExtractText(),
            new webpack.ProvidePlugin({}),
            new webpack.DefinePlugin({
                'process.env.NODE_ENV': isDevBuild ? '"development"' : '"production"'
            }),
            new webpack.DllPlugin({
                path: path.join(__dirname, 'wwwroot', 'dist', '[name]-manifest.json'),
                name: '[name]_[hash]'
            })
        ].concat(isDevBuild ? [] : [
            new pluginUglifyJS()
        ])
    }];
};