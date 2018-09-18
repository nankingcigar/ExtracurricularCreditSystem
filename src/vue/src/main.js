/*
* @Author: Chao Yang
* @Date: 2017-12-11 09:18:43
 * @Last Modified by: Chao Yang
 * @Last Modified time: 2017-12-14 06:24:37
*/
// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import axios from 'axios'

import App from './App'
import i18n from './app.i18n'
import router from './router'
import './route.interceptor'
import './axios.interceptor'

Vue.prototype.$http = axios

Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  i18n,
  template: '<App/>',
  components: { App }
})
