/*
* @Author: Chao Yang
* @Date: 2017-12-11 09:07:35
 * @Last Modified by: Chao Yang
 * @Last Modified time: 2017-12-14 03:14:53
*/
<template>
  <div class="m-login__signin">
    <div class="m-login__head">
      <h3 class="m-login__title">
        {{ $t("views.signin.body.title") }}
      </h3>
    </div>
    <form class="m-login__form m-form" action="">
      <div class="form-group m-form__group">
        <input class="form-control m-input"   type="text" placeholder="User Name" name="userName" autocomplete="off" v-model="userName" />
      </div>
      <div class="form-group m-form__group">
        <input class="form-control m-input m-login__form-input--last" type="password" placeholder="Password" name="password" v-model="password" />
      </div>
      <div class="row m-login__form-sub">
        <div class="col m--align-left m-login__form-left">
          <label class="m-checkbox  m-checkbox--focus">
            <input type="checkbox" name="remember" v-model="rememberMe"/>
            Remember me
            <span></span>
          </label>
        </div>
        <div class="col m--align-right m-login__form-right">
          <a href="javascript:;" id="m_login_forget_password" class="m-link">
            Forget Password ?
          </a>
        </div>
      </div>
      <div class="m-login__form-action">
        <button id="m_login_signin_submit" class="btn btn-focus m-btn m-btn--pill m-btn--custom m-btn--air m-login__btn m-login__btn--primary" v-on:click="onSignIn">
          Sign In
        </button>
      </div>
    </form>
  </div>
</template>

<script>
import $ from '@/$'
import SessionService from '@/service/session/session.service'

export default {
  name: 'signin',
  props: {},
  data () {
    return {
      userName: undefined,
      password: undefined,
      rememberMe: false
    }
  },
  methods: {
    onSignIn: function (event) {
      event.preventDefault()
      const btn = $(event.target)
      const form = btn.closest('form')
      form.validate({
        rules: {
          userName: {
            required: true
          },
          password: {
            required: true
          }
        }
      })
      if (!form.valid()) {
        return
      }
      btn
        .addClass('m-loader m-loader--right m-loader--light')
        .attr('disabled', true)
      SessionService.create(this.userName, this.password).then(data => {
        console.log(data)
      })
    }
  }
}
</script>

<style>

</style>
