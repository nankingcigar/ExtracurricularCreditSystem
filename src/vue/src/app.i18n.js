/*
* @Author: Chao Yang
* @Date: 2017-12-14 06:21:09
 * @Last Modified by: Chao Yang
 * @Last Modified time: 2017-12-14 06:22:59
*/
import Vue from 'vue'
import VueI18n from 'vue-i18n'

import axios from 'axios'
import Cookies from 'js-cookie'

import app from './app.global'
import router from './router'

Vue.use(VueI18n)

const messages = {
}

function setLanguage (locale, next) {
  if (!messages[locale]) {
    axios.get(app.i18n.path(locale)).then((data) => {
      messages[locale] = data
      Cookies.set(app.i18n.key, locale)
      i18n.locale = locale
      if (next) {
        next()
      }
    })
  } else {
    i18n.locale = locale
  }
}

router.beforeEach((to, from, next) => {
  setLanguage(Cookies.get(app.i18n.key) || app.i18n.default, next)
  router.beforeHooks.splice(0, 0)
})

const i18n = new VueI18n({
  locale: Cookies.get(app.i18n.key) || app.i18n.default,
  fallbackLocale: app.i18n.default,
  messages
})

i18n.setLocale = function (locale) {
  setLanguage(locale)
}

export default i18n
