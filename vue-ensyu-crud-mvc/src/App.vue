<script setup>
import { RouterLink, RouterView } from 'vue-router'
import HelloWorld from './components/HelloWorld.vue'
</script>

<template>
  <div>
  <nav>
    <RouterLink to="/">Home</RouterLink>
  </nav>
  </div>

  <RouterView />
</template>