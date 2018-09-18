/*
* @Author: Chao Yang
* @Date: 2017-12-12 07:09:16
 * @Last Modified by: Chao Yang
 * @Last Modified time: 2017-12-12 07:19:21
*/
import BaseService from '../base.service'
import SessionProxy from '@/proxy/session/session.proxy'

export default {
  create: function (name, password) {
    return BaseService.promise(() => {
      return SessionProxy.create({
        name: name,
        password: password
      })
    })
  }
}
