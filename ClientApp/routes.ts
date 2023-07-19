import VueRouter from "vue-router";

export function createRouter(): VueRouter {
    const routes: any = [
        {path: '/', component: require('./Home/Index.vue').default, meta: {allowAnonymous: true}, props: true},
        /*{path: '/Account/LostPassword', component: require('./Account/LostPassword.vue').default, meta: {allowAnonymous: true}},*/
        // stub for all other urls
        {path: '*', component: require('./Home/NotImplemented.vue').default},
        {path: "/menu", component: require("./Pages/Main/MainPage.vue").default, meta: {allowAnonymous: true}, props: true},
        {path: "/docs", component: require("./Pages/CreateDocuments/CreateDocumentsPage.vue").default, meta: {allowAnonymous: true}, props: true},
        {path: "/ticket", component: require("./Pages/Tickets/TicketPage.vue").default, meta: {allowAnonymous: true}, props: true},
        {path: "/tickets", component: require("./Pages/Tickets/TicketsPage.vue").default, meta: {allowAnonymous: true}, props: true}
    ];

    let router = new VueRouter({mode: 'history', routes: routes});
    return router;
}