<template>
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <h1>Page not found, 404</h1>
            </div>
        </div>
    </div>
</template>

<script lang="ts">
import {Component} from 'vue-property-decorator';
import Vue from "vue"

@Component
export default class NotImplementedComponent extends Vue {
    mounted() {
        this.refresh();
    }

    refresh() {
        // this.post("/Devices/Types/Load", {})
        //     .done((r: any) => {
        //         this.Items = r.Items;
        //     });
    }
}
</script>