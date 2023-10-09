  <template>
  <div id='app-root' :key="key">
    <HatBar></HatBar>
    <router-view class="pt-2"></router-view>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import {Component} from 'vue-property-decorator';
import {eventBus} from "./boot";
import HatBar from "./Pages/Components/HatBar.vue";
import User from "./Config/Objects/SystemFrontObjects/User";
import TicketsDownload from "./Scripts/Tickets/TicketsDownload";

@Component({
  components: {HatBar}
})

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

html, body, #app-root, #content, .pt-2
{
  height: 100%;
  width: 100%;
}

</style>