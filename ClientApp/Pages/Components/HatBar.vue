<template>
  <div>
    <b-navbar class="navbar" type="is-info">
      <template #brand>
        <b-navbar-item tag="router-link" :to="{path: '/menu'}">
          <img src="https://lab-td.ru/wp-content/uploads/2020/10/ТД-лого-син-ор.png" alt="Лаборатория Тест-Драйв">
        </b-navbar-item>
      </template>
      
      <template #end>
        <b-navbar-item>Сайт компании</b-navbar-item>
        
        <b-navbar-dropdown label="Рабочие интерфейсы">
          <b-navbar-item>CRM</b-navbar-item>
          <b-navbar-item>Carcoin</b-navbar-item>
          <b-navbar-item>SertAuto</b-navbar-item>
          <b-navbar-item>Telegram</b-navbar-item>
          <b-navbar-item>WhatsApp</b-navbar-item>
          <b-navbar-item>Yandex.Mail</b-navbar-item>
        </b-navbar-dropdown>

        <b-navbar-dropdown label="Функционал сайта">
          <b-navbar-item tag="router-link" :to="{path: '/docs'}">Формирование документов</b-navbar-item>
          <b-navbar-item>Справка</b-navbar-item>
        </b-navbar-dropdown>
        
        <b-navbar-item>
          <b-button type="is-warning">Войти</b-button>
        </b-navbar-item>
        <b-navbar-item>
          <b-button type="is-warning">Регистрация</b-button>
        </b-navbar-item>
      </template>
    </b-navbar>
  </div>
</template>

<script lang="ts">

import Vue from "vue";

export default class HatBar extends Vue
{
  name: string = "HatBar";
}
</script>

<style>

</style>