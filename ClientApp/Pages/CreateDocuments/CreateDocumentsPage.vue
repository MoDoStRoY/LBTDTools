<template>
  <div>
    <div class="leftBlock">
      <b-switch type="is-info">Заявление-декларация</b-switch>
      <b-switch type="is-info">Акт измерения</b-switch>
    </div>

    <div class="centerBlock">
      <b-button type="is-warning" v-on:click="displayMod('displayModFlag')">{{displayModBtnTitle}}</b-button>
      <div v-if="displayModFlag">
        <h1><strong>Внесённые изменения в конструкцию</strong></h1>
        <b-tabs>
          <b-tab-item label="Джиповый тюнинг">
            <b-field label="Передняя часть ТС">
              <b-switch>Силовой бампер</b-switch>
              <b-switch>Лебедка</b-switch>
              <b-switch>Защитная дуга</b-switch>
              <b-switch>Козырёк</b-switch>
              <b-switch>Пороги</b-switch>
            </b-field>

            <b-field label="Задняя часть ТС">
              <b-switch>Силовой бампер</b-switch>
              <b-switch>Лебёдка</b-switch>
              <b-switch>Защитная дуга</b-switch>
              <b-switch>Кронштейн для запаски</b-switch>
              <b-switch>Кронштейн для запаски на задней двери</b-switch>
              <b-switch>Кунг</b-switch>
            </b-field>

            <b-field label="Крыша">
              <b-switch>Экспедиционный багажник</b-switch>
              <b-switch>Лестница</b-switch>
              <b-switch>Аварийно-вентиляционный люк</b-switch>
              <b-switch>Металлическая крыша</b-switch>
            </b-field>

            <b-field label="Осветительное оборудование">
              <b-switch>Доп.фары дальнего света</b-switch>
              <b-switch>Дневные ходовые огни</b-switch>
              <b-switch>Противотуманки</b-switch>
              <b-switch>Рабочий свет</b-switch>
            </b-field>

            <b-field label="ДВС">
              <b-switch>Шноркель</b-switch>
              <b-switch>Защита ДВС</b-switch>
            </b-field>

            <b-field label="Прочая внутрянка">
              <b-switch>Защита рулевых тяг</b-switch>
              <b-switch>Защита КПП</b-switch>
              <b-switch>Дисковые тормоза (перед)</b-switch>
              <b-switch>Дисковые тормоза (зад)</b-switch>
              <b-switch>Рулевой демпфер</b-switch>
              <b-switch>Гидроусилитель руля</b-switch>
              <b-switch>Спальник</b-switch>
            </b-field>

            <b-field label="Лифт">
              <b-switch>Пружины</b-switch>
              <b-switch>Проставки</b-switch>
            </b-field>

            <b-field label="Колёса">
              <b-switch>Увеличенные шины</b-switch>
              <b-switch>Расширители арок</b-switch>
            </b-field>
          </b-tab-item>

          <b-tab-item label="Гражданское переоборудование">
            <b-switch>ГБО (монтаж)</b-switch>
            <b-switch>ГБО (демонтаж)</b-switch>
            <b-switch>Смена ДВС</b-switch>
            <b-switch>Смена категории</b-switch>
          </b-tab-item>

          <b-tab-item label="Спец.техника">
            <b-switch>Снятие брони</b-switch>
            <b-switch>КМУ (монтаж)</b-switch>
            <b-switch>АГП (монтаж)</b-switch>
            <b-switch>КБУ (монтаж)</b-switch>
            <b-switch>Бортовая платформа (монтаж)</b-switch>
            <b-switch>Самосвальная платформа (монтаж)</b-switch>
            <b-switch>Рефа</b-switch>
          </b-tab-item>
        </b-tabs>
      </div>
      
      <hr>

      <b-button v-on:click="displayMod('displayILFlag')" type="is-warning">{{displayILBtnTitle}}</b-button>
      <div v-if="displayILFlag">
        <h1><strong>Данные по ИЛ и заключению</strong></h1>
        
        <b-field grouped>
          <b-field label="Испытательная лаборатория, выпустившая заключение">
            <b-select placeholder="Выберите ИЛ" expanded>
              <option value="AT">Академ-Тест</option>
              <option value="EGBO">Эксперт-ГБО</option>
              <option value="PA">Проф-Авто</option>
              <option value="IC">Испытательный центр</option>
            </b-select>
          </b-field>
          
          <b-field label="Дата выпуска заключения">
            <b-input placeholder="Например: 12.11.2021"></b-input>
          </b-field>

          <b-field label="Номер заключения">
            <b-input placeholder="Например: ПТЭАП01-38024"></b-input>
          </b-field>
        </b-field>
        </div>
        
        <hr>
        
        <b-button v-on:click="displayMod('displayServiceFlag')" type="is-warning">{{displayServiceBtnTitle}}</b-button>
        <div v-if="displayServiceFlag">
          <h1><strong>Данные по производителю работ и датам</strong></h1>
          <b-field label="Производитель работ">
            <b-input placeholder="Например: ИП Васильев П.А."></b-input>
          </b-field>
          <b-field label="А также с полными ФИО">
            <b-input placeholder="Например: ИП Васильев Павел Александрович"></b-input>
          </b-field>
          <b-field label="Юридический адрес">
            <b-input placeholder="Например: Челябинск, ул.Пекинская д.28"></b-input>
          </b-field>

          <b-field label="Сертификат соответствия" grouped>
            <b-field label="Дата выдачи" expanded>
              <b-input placeholder="Например: 12.03.1998"></b-input>
            </b-field>
            <b-field label="Номер сертификата" expanded>
              <b-input placeholder="Например: РОСС RU.318472.05СЯС1"></b-input>
            </b-field>
            <b-field label="Кем выдан" expanded>
              <b-input placeholder="Например: органом по сертификации «Национальный научно-исследовательский институт экологии и сертификации»"></b-input>
            </b-field>
          </b-field>
          
          <b-field label="Дата и место проведения" grouped>
            <b-field label="Дата выполнения работ" expanded>
              <b-input placeholder="Например: 12.03.1998"></b-input>
            </b-field>
            <b-field label="Дата проведения замеров" expanded>
              <b-input placeholder="Например: 12.03.1998"></b-input>
            </b-field>
            <b-field label="Дата предоставления ТС" expanded>
              <b-input placeholder="Например: 12.03.1998"></b-input>
            </b-field>
          </b-field>
        </div>
    </div>
    
    <hr>

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
  displayModFlag: boolean = true;
  displayModBtnTitle: string = "Скрыть виды переоборудования";
  displayILFlag: boolean = true;
  displayILBtnTitle: string = "Скрыть данные по ИЛ";
  displayServiceFlag: boolean = true;
  displayServiceBtnTitle: string = "Скрыть данные по производителю работ";

  displayMod(flag: string): void
  {
    switch (flag)
    {
      case "displayModFlag":
        if (this.displayModFlag)
        {
          this.displayModFlag = false;
          this.displayModBtnTitle = "Показать виды переоборудования"
        }
        else
        {
          this.displayModFlag = true;
          this.displayModBtnTitle = "Скрыть виды переоборудования"
        }
        break;
      case "displayILFlag":
        if (this.displayILFlag)
        {
          this.displayILFlag = false;
          this.displayILBtnTitle = "Показать данные по ИЛ"
        }
        else
        {
          this.displayILFlag = true;
          this.displayILBtnTitle = "Скрыть данные по ИЛ"
        }
        break;
      case "displayServiceFlag":
        if (this.displayServiceFlag)
        {
          this.displayServiceFlag = false;
          this.displayServiceBtnTitle = "Показать виды переоборудования"
        }
        else
        {
          this.displayServiceFlag = true;
          this.displayServiceBtnTitle = "Скрыть виды переоборудования"
        }
        break;
    }
  }
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

.inline
{
  display: inline-block;
}

</style>