import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView,
    },
    {
      path: '/todolist',
      name: 'todolist',
      component: ()=> import("../views/ToDoListView.vue"),
    },
    {
      path: '/todo/:id',
      name: 'todo',
      component: ()=> import("../views/ToDoView.vue"),
    },
  ],
})

export default router
