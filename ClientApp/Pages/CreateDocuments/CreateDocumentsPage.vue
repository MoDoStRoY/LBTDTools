<template>
  <div>
    <div class="leftBlock">
      <b-switch type="is-info">Заявление-декларация</b-switch>
      <b-switch type="is-info">Акт измерения</b-switch>
    </div>

    <div class="centerBlock">
      
    </div>

    <div class="rightBlock">

    </div>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import {Component} from "vue-property-decorator";

@Component
export default class CreateDocumentsPage extends Vue
{
  name: string = "CreateDocumentsPage";
  
  
}
</script>

<style>

.leftBlock, .rightBlock
{
  width: 20%;
  height: 100%;
  float: left;
}

.centerBlock
{
  width: 60%;
  height: 100%;
  float: left;
  margin: 0;
}

</style>