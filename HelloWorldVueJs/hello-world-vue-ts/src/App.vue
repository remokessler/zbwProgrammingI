<template>
  <div id="app">
    <MyFirstComponent/>
  </div>
</template>

<script>
// import HelloWorld from './components/HelloWorld.vue';
import MyFirstComponent from './components/my-first-component/my-first-component.vue';

export default {
  name: 'app',
  components: {
    // HelloWorld,
    MyFirstComponent
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
