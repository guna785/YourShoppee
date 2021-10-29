import { createRouter, createWebHistory, RouteRecordRaw } from 'vue-router';
import LandingPage from '../views/LandingPage.vue'
import Vegitables from '../views/Vegitables.vue';

const routes: Array<RouteRecordRaw> = [
    { path: "/", component: LandingPage },
    { path: "/Vegitables", component: Vegitables }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
