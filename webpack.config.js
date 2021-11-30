const path = require('path');
const webpack = require('webpack');
const pluginExtractText = require('mini-css-extract-plugin');
const pathOUTPUT = './wwwroot/dist';
const pluginVueLoader = require('vue-loader/lib/plugin');

module.exports = function(env) {
    const isDevBuild = !(env && env.prod);
    const devMode = isDevBuild ? 'development':'production';

    return [{
        mode: devMode,
        stats: { modules: false },
        context: __dirname,
        resolve: { extensions: [ '.js', '.ts' ] },
        entry: { 'main': './ClientApp/boot.ts' },
        module: {
            rules: [
                { test: /\.vue$/, include: /ClientApp/, loader: 'vue-loader', options: { loaders: { js: 'ts-loader' } } },
                { test: /\.ts$/, include: /ClientApp/, use: [
                    {
                        loader: 'ts-loader',
                        options: {
                            appendTsSuffixTo: [/\.vue$/]
                        }
                    }
                ] },
                { test: /\.css$/, use: isDevBuild ? [ 'style-loader', 'css-loader' ] : [pluginExtractText.loader, 'css-loader'] },
                { test: /\.(png|jpg|jpeg|gif|svg)$/, use: 'url-loader?limit=25000' },
                {
                    test: /\.scss$/,
                    use: [
                        "style-loader", // creates style nodes from JS strings
                        "css-loader", // translates CSS into CommonJS
                        "sass-loader" // compiles Sass to CSS, using Node Sass by default
                    ]
                },
                {
                    test: /\.(woff|woff2|ttf|eot)$/,
                    use: 'file-loader?name=fonts/[name].[ext]!static'
                }
            ]
        },
        output: {
            path: path.join(__dirname, pathOUTPUT),
            filename: '[name].js',
            publicPath: 'dist/'
        },
        plugins: [
            new pluginVueLoader(),
            new webpack.DefinePlugin({
                'process.env': {
                    NODE_ENV: JSON.stringify(isDevBuild ? 'development' : 'production')
                }
            })
        ].concat(isDevBuild ? [
            // Plugins that apply in development builds only
            new webpack.SourceMapDevToolPlugin({
                filename: '[file].map', // Remove this line if you prefer inline source maps
                moduleFilenameTemplate: path.relative(pathOUTPUT, '[resourcePath]') // Point sourcemap entries to the original file locations on disk
            })
        ] : [
            // Plugins that apply in production builds only
            new pluginExtractText([{filename:'site.css'}])
        ])
    }];
};