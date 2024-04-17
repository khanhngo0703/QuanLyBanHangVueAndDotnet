import { createRouter, createWebHistory } from 'vue-router'
import HomeView from './views/HomeView.vue'; 
import ProductView from './views/ProductView.vue'; 
import BillView from './views/BillView.vue'; 
import RegisterView from './views/RegisterView.vue'; 
import LoginView from './views/LoginView.vue'; 
import ForgotPasswordView from './views/ForgotPasswordView.vue'; 


const routes = [
  {
    path: '/',
    name: 'HomeView',
    component: HomeView,
    meta: { requiresAuth: true } // Thêm meta data để chỉ định rằng trang cần đăng nhập
  },
  {
    path: '/product',
    name: 'ProductView',
    component: ProductView
  },
  {
    path: '/bill',
    name: 'BillView',
    component: BillView
  },
  {
    path: '/register',
    name: 'RegisterView',
    component: RegisterView
  },
  {
    path: '/login',
    name: 'LoginView',
    component: LoginView
  },
  {
    path: '/forgotpassword',
    name: 'ForgotPasswordView',
    component: ForgotPasswordView
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})
router.beforeEach((to, from, next) => {
  // Kiểm tra meta data của trang
  if (to.meta.requiresAuth && to.path !== '/login') {
    const token = localStorage.getItem('token');
    if (!token) {
      // Chưa đăng nhập, chuyển hướng đến trang đăng nhập
      next('/login');
    } else {
      // Đã đăng nhập, cho phép truy cập vào trang
      next();
    }
  } else {
    // Trang không yêu cầu đăng nhập, cho phép truy cập
    next();
  }

});
export default router
