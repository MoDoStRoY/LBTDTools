<template>
  <div>
    
    <div class="leftBlock">
      
    </div>

    <div class="centerBlock">
      <b-table :data="feed"
               detailed
               detail-key="detailId"
               paginated
               per-page="10">

        <b-table-column field="title" label="Новости" width="50%" numeric v-slot="props">{{props.row.title}}</b-table-column>
        <b-table-column field="date" label="Публикация" width="50%" numeric v-slot="props">{{props.row.date}}</b-table-column>

        <template #detail="props">
          <article>
            <p>{{props.row.details}}</p>
          </article>
        </template>

      </b-table>
    </div>

    <div class="rightBlock">

    </div>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import {Component} from 'vue-property-decorator';

@Component
export default class MainPage extends Vue 
{
  name: string = "MainPage";
  
  feed: any[] =
      [
        {"title": "Совещание в НАМИ", "date": "01.12.2021", "details": "Завтра 2 декабря будет проходить рабочее совещание в НАМИ по вопросам переоборудования дистанционки, ГОСТа. Туда приглашены представители ИЛ, по словам которых будут хорошие новости по дистанционке. Ждем 🤞"},
        {"title": "БИТРИКС 24", "date": "01.12.2021", "details": "Коллеги, у нас в компании принято заканчивать месяц и начинать новый с проверки всех сделок в рамках СРМ системы. Мы актуализируем этапы, проставляем задачи (там где их нет) и планируем действия и выставляем планы на следующий месяц.\n" +
              "\n" +
              "Обратите внимание, что в воронках ПАКЕТ, ПАКЕТ через УК, СКТС, ПОД КЛЮЧ у многих есть сделки, которые уже давно не актуальны и завершены. Настало время отправить их в реализованные.\n" +
              "\n" +
              "Аналогичная ситуация и по лидам, возможно многие из них уже давно не актуальны и пора их отправить в нереализованные. \n" +
              "\n" +
              "Пожалуйста приведите СРМ систему в порядок до конца недели."},
        {"title": "Просьба помочь с Авито", "date": "30.11.2021", "details": "Александр (Ижевск) нуждается в помощи коллег по вопросам работы с авито. Поддержка блокирует объявления, нужен опыт регионов в которых происходили аналогичные ситуации и то как вы их решили. Пожалуйста напишите об это Александру. Таких регионов не много, поэтому не проходите мимо этого сообщения."}
      ]
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