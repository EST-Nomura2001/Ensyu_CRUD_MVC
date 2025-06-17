<script setup>
import axios from 'axios';
import getUrl from '@/data/getUrl.js';
import {ref , onMounted} from 'vue';
import {useRouter} from 'vue-router';

const router = useRouter();//現在のルートを取得

const title = ref('');
const summary = ref('');
const fixedDate = ref(null);

const submit = async ()=>{
    try{
        console.log("送信内容",title.value,fixedDate.value,summary.value)
        await axios.post(getUrl.toDoListUrl,{
            title:title.value,
            summary:summary.value,
            fixedDate:fixedDate.value,
        });
        alert("成功");
        await router.push('/todolist');//一覧へ遷移
    }
    catch(error){
        console.error("エラー",error);
        alert("失敗");
    }
};
</script>
<template>
    <div>
        <p>
            タイトル：<input type="text" v-model="title" placeholder="タイトルを入力">
            日付：<input type="date" v-model="fixedDate" placeholder="0000/00/00">
        </p>
        <p>
            本文：<br>
            <textarea v-model="summary" placeholder="本文を入力"></textarea>
        </p>
        <input type="button" value="追加" @click="submit">   
    </div>
</template>