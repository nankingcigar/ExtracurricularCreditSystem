import router from './router'

router.beforeEach((to, from, next) => {
  console.log(to)
  console.log(from)
  console.log(next)
  next()
})

router.afterEach(() => {

})
