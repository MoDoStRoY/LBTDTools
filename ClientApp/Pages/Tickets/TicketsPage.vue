<template>
  <div>
    <div class="leftBlock">
      <b-field><b-button label="Новые обращения" type="is-warning" v-model="newTicketsFlag" @click="changeFunnel('newTickets')" expanded></b-button></b-field>
      <b-field><b-button label="Переоборудование" type="is-warning" expanded></b-button></b-field>
      <b-field><b-button label="СБКТС" type="is-warning" expanded></b-button></b-field>
      <b-field><b-button label="ЭПТС" type="is-warning" expanded></b-button></b-field>
    </div>

    <div class="centerBlock">
      <b-tabs v-if="newTicketsFlag">
        <b-tab-item label="Обработка новой заявки">
          <b-tabs>
            <b-tab-item label="Новая заявка">
              <b-table
              :data = "listOfNewRequests">
                <b-button label="+ Создать +" type="is-warning" expanded></b-button>
                <b-table-column label="ID" width="10%" v-slot="props"> {{props.row.id}} </b-table-column>
                <b-table-column label="Название" width="65%" v-slot="props"> <b-button type="is-warning" expanded>{{props.row.name}}</b-button></b-table-column>
                <b-table-column label="Крайний срок" width="20%" v-slot="props"> {{props.row.dateAndTime}} </b-table-column>
                
              </b-table>
            </b-tab-item>
            <b-tab-item label="Принято в работу">

            </b-tab-item>
            <b-tab-item label="Проверка возможности оказания услуги">

            </b-tab-item>
          </b-tabs>
        </b-tab-item>
        <b-tab-item label="Подготовка к договору">
          <b-tabs>
            <b-tab-item label="Запрошены документы">
              
            </b-tab-item>
            <b-tab-item label="Подготовка договора">

            </b-tab-item>
            <b-tab-item label="Договор отправлен">

            </b-tab-item>
          </b-tabs>
        </b-tab-item>
      </b-tabs>
    </div>
    
    <div class="rightBlock">
      
    </div>
    
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import {Component} from "vue-property-decorator";
import CommentInCard from "../../Config/Objects/SystemFrontObjects/CommentInCard";
import TicketPreview from "../../Config/Objects/SystemFrontObjects/TicketPreview";
import TicketsDownload from "../../Scripts/Tickets/TicketsDownload";

@Component
export default class TicketsPage extends Vue 
{
  name: string = "TicketsPage";
  listOfNewRequests: Array<TicketPreview> = [];

  //** Флаги воронок **//
  newTicketsFlag: boolean = false;
  
  data()
  {
    return {
      listOfNewRequests: TicketsDownload.downloadAllTicketsPreview(this.$root.$data.GlobalStore.userID),
    }
  }
  
  changeFunnel(flag: string)
  {
    switch (flag) 
    {
      case 'newTickets':
      {
        if (this.newTicketsFlag) 
          this.newTicketsFlag = false;
        else 
          this.newTicketsFlag = true;
      }
    }
  }
}
</script>

<style>

.leftBlock {
  width: 20%;
  height: 100%;
  float: left;
  margin: 5px;
}

.centerBlock {
  width: 55%;
  height: 100%;
  float: left;
  margin: 5px;
}

.rightBlock {
  width: 20%;
  height: 100%;
  float: left;
  margin: 5px;
}

</style>