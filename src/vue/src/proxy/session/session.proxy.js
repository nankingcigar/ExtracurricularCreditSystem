/*
* @Author: Chao Yang
* @Date: 2017-12-12 07:01:41
 * @Last Modified by: Chao Yang
 * @Last Modified time: 2017-12-12 07:18:51
*/
import axios from 'axios'

import app from '@/app.global'

export default {
  create: function (input) {
    return axios.post(app.api.session.single, input)
  }
}
