<template>
  <div>{{test}}</div>
</template>

<script lang="ts">

import {Component, Vue} from "vue-property-decorator";

@Component
export default class Index extends Vue {
  test = "хуй12311111";
}
</script>

<style scoped>

</style>