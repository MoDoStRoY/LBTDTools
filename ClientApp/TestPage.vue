<template>
  <div>
    <router-view></router-view>
    <input v-model="test"></input>
    <p>хуй</p>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import {Component} from 'vue-property-decorator';

@Component
export default class TestPage extends Vue 
{
  test: string = "huy1234567";
  created(): void {}
}
</script>

<style lang="scss">

/*@import '../ClientApp.Styles/common.scss';
@import '../ClientApp.Styles/buefy-fixes.scss';
@import '../ClientApp.Styles/fonts.scss';*/

</style>