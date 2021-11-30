<template>
  <div id='app-root' :key="key">
    <router-view class="pt-2"></router-view>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import {Component} from 'vue-property-decorator';
import {eventBus} from "./boot";

@Component
export default class AppComponent extends Vue {
  key = 0;
  
  created(): void {
    eventBus.$on('locale-update', () => {
      this.key++;
    });
  }
}
</script>

<style lang="scss">

/*@import '../ClientApp.Styles/common.scss';
@import '../ClientApp.Styles/buefy-fixes.scss';
@import '../ClientApp.Styles/fonts.scss';*/

</style>