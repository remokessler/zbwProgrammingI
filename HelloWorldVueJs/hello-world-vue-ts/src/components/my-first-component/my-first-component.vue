<template>
<div>
    <h1>
        My First Component
    </h1>
    <input v-model="val1" type="textbox" placeholder="Value 1"/>
    <br/>
    <input v-model="val2" type="textbox" placeholder="Value 2"/>
    <br/>
    <button v-on:click="setResult()">Start!</button>
    <br/>
    <p> Value 1 {{result}} Value 2</p>
</div>
</template>
<script lang="ts" src="./my-first-component.ts"></script>