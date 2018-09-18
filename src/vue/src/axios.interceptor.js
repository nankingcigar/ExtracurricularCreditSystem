import axios from 'axios'

axios.interceptors.request.use(
  (config) => {
    console.log(config)
    return config
  },
  (error) => {
    return Promise.reject(error)
  }
)

axios.interceptors.response.use(
  (response) => {
    if (response.status === 200) {
      response = response.data
    }
    console.log(response)
    return response
  },
  (error) => {
    return Promise.reject(error)
  }
)
