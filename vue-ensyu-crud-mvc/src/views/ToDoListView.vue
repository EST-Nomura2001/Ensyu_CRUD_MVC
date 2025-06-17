<script setup>
import ShowToDoList from '../components/ShowToDoList.vue'
import {RouterLink} from 'vue-router';
import {ref} from 'vue';
import AddToDo from '@/components/AddToDo.vue';

const isVaildAdd = ref(false);
const isVaildList = ref(true);

const showAdd = ()=>{
    isVaildAdd.value = true;
    isVaildList.value = false;
}

const showList = ()=>{
    isVaildAdd.value = false;
    isVaildList.value = true;
};
</script>

<template>
    <div v-if="isVaildList">
        <ShowToDoList />
        <button @click="showAdd">追加</button>
    </div>

    <div v-if="isVaildAdd">
        <AddToDo/>
        <button @click="showList">戻る</button>
    </div>
</template>