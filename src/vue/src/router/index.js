/*
* @Author: Chao Yang
* @Date: 2017-12-11 09:07:46
 * @Last Modified by: Chao Yang
 * @Last Modified time: 2017-12-14 06:00:01
*/
import Vue from 'vue'
import Router from 'vue-router'

import SignInLayout from '@/view/signin/layout.view'
import Signin from '@/view/signin/signin.view'

Vue.use(Router)

const router = new Router({
  routes: [
    {
      path: '/signin',
      component: SignInLayout,
      redirect: '/signin/index',
      children: [
        {
          path: 'index',
          component: Signin
        },
        {
          path: '',
          redirect: 'index'
        }
      ]
    },
    {
      path: '',
      redirect: 'signin'
    },
    {
      path: '*',
      redirect: 'signin'
    }
  ]
})

export default router
