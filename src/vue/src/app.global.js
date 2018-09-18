/*
* @Author: Chao Yang
* @Date: 2017-12-12 07:09:06
 * @Last Modified by: Chao Yang
 * @Last Modified time: 2017-12-14 06:17:04
*/
const app = {
  prefix: 'cec',
  i18n: {
    key: 'cec-language',
    default: 'zh-cn',
    path: function (code) {
      return '/static/i18n/' + code + '.json'
    },
    languages: [
      {
        code: 'zh-cn',
        text: '简体中文'
      },
      {
        code: 'en',
        text: 'English'
      }
    ]
  },
  api: {
    session: {
      single: '/api/session'
    }
  }
}

export default app
