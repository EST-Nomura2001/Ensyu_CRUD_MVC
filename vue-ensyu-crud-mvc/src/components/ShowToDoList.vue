<script setup>
import axios from 'axios';
import getUrl from '@/data/getUrl.js';
import {ref , onMounted} from 'vue';
import {RouterLink} from 'vue-router';

const url = getUrl.toDoListUrl;
const toDoList = ref([]);

onMounted( async ()=>
{
    try{
        console.log("URL：",url);
        const response = await axios.get(url);
        toDoList.value = response.data
        console.log(toDoList.value);
    }
    catch(error){
        console.error("エラーログ",error);
    }
}
);
</script>

<template>
    <table border="1">
        <tr>
            <th>ID</th>
            <th>Title</th>
            <th>期日</th>
        </tr>
        <tr v-for="todo in toDoList" :key="todo.id">
            <th>{{ todo.id }}</th>
            <th><RouterLink :to="{name:'todo',params:{id: todo.id}}">
                {{ todo.title }}
            </RouterLink></th>
            <th>{{ todo.fixedDate }}</th>
        </tr>
    </table>
</template>