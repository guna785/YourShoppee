import { createRouter, createWebHistory, RouteRecordRaw } from 'vue-router';
import LandingPage from '../views/LandingPage.vue'
import ProductPage from '../views/ProductPage.vue';
import AdminPage from '../views/AdminPage.vue';
import Login from '../views/Login.vue';
const routes: Array<RouteRecordRaw> = [
    { path: "/", component: LandingPage },
    { path: "/Products", component: ProductPage },
    { path: "/Admin", component: AdminPage },
    { path: "/Login", component: Login }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
