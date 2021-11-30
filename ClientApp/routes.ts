import VueRouter from "vue-router";

export function createRouter(): VueRouter {
    const routes: any = [
        {path: '/', component: require('./Home/Index.vue').default, meta: {allowAnonymous: true}, props: true},
        /*{path: '/Account/LostPassword', component: require('./Account/LostPassword.vue').default, meta: {allowAnonymous: true}},*/
        // stub for all other urls
        {path: '*', component: require('./Home/NotImplemented.vue').default},
        {path: '/test', component: require('./TestPage.vue').default, meta: {allowAnonymous: true}, props: true},
    ];

    let router = new VueRouter({mode: 'history', routes: routes});
    return router;
}