
import Buefy from 'buefy';

import Vue from 'vue';
import VueRouter from 'vue-router';
import Validate from 'vuelidate';

import {createRouter} from "./routes";
import moment from 'moment';
import User from "./Config/Objects/SystemFrontObjects/User";
import GlobalStore from "./Config/Objects/SystemFrontObjects/GlobalStore";

Vue.prototype.$moment = moment;
Vue.use(Buefy, {defaultIconPack: 'fa'});
Vue.use(VueRouter);
Vue.use(Validate);

export const eventBus = new Vue();

export const DEBUG: boolean = !!(<any>window)["webpackHotUpdate"];

// COMPONENTS
/*Vue.component("MenuMain", require('../ClientApp.Components/menu/Menu.vue').default);*/

// VUE
export let vue = new Vue({
    el: '#app-root',
    router: createRouter(),
    render: h => h(require('./app.vue').default),
    data: {
        Busy: false,
        GlobalStore
    }
});