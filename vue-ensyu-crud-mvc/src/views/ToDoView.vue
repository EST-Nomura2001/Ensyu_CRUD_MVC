<script setup>
import ShowToDo from '../components/ShowToDo.vue'
import {RouterLink} from 'vue-router'
</script>

<template>
    <ShowToDo/>
    <button><RouterLink to="/todolist">戻る</RouterLink></button>
</template>