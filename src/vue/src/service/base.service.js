/*
* @Author: Chao Yang
* @Date: 2017-12-12 07:16:52
 * @Last Modified by: Chao Yang
 * @Last Modified time: 2017-12-12 07:21:15
*/

export default {
  promise: function (lambda) {
    return new Promise((resolve, reject) => {
      lambda().then(
        (response, data) => {
          resolve(data)
        })
        .catch((error) => {
          reject(error)
        })
    })
  }
}
