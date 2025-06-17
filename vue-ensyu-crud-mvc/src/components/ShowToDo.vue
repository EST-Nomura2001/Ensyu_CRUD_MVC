<script setup>
import axios from 'axios';
import getUrl from '@/data/getUrl.js';
import {ref , onMounted} from 'vue';
import {RouterLink,useRoute,useRouter} from 'vue-router';

const route = useRoute();
const router = useRouter();
const thisId = ref(1);
const toDo = ref([]);

onMounted(async ()=>{
    try{
        thisId.value = route.params.id;
        console.log("ID:",thisId.value);
        const response = await axios.get(getUrl.toDoListUrl);
        console.log("response",response.data);
        toDo.value = response.data.find(d => d.id==thisId.value);
        console.log("TODO",toDo.value)
    }
    catch(error){
        console.error("エラー",error);
    }
});

const deleteToDo = async(id)=>{
try{
    console.log("削除対象",`${getUrl.toDoListUrl}/${id}`)
    await axios.delete(`${getUrl.toDoListUrl}/${id}`);
    alert("削除成功");
    await router.push('/todolist');//一覧へ遷移
}
catch(error){
    console.error("エラー",error);
    alert("削除失敗");
}
}
</script>
<template>
    <h1>{{ toDo.title }}</h1>
    <p>{{ toDo.fixedDate }}</p>
    <p>{{ toDo.summary }}</p>
    <p>
        <button>編集</button>
        <button @click="deleteToDo(toDo.id)">削除</button>
    </p>
</template>