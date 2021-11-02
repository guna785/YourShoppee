import { createRouter, createWebHistory, RouteRecordRaw } from 'vue-router';
import LandingPage from '../views/LandingPage.vue'
import ProductPage from '../views/ProductPage.vue';
import AdminPage from '../views/AdminPage.vue';
import Login from '../views/Login.vue';
const routes: Array<RouteRecordRaw> = [
    { path: "/", component: LandingPage,name:'LandingPage' },
    { path: "/Products", component: ProductPage ,name:'Products'},
    { path: "/Admin", component: AdminPage ,name:'Admin'},
    { path: "/Login", component: Login ,name:'Login'}
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
