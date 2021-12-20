<template>
  <div>
    <div class="leftBlock">
      
      <div>
        <b-field grouped label="Выпускаемый документ">
          <b-field>
            <b-button icon-left="download" type="is-ghost"></b-button>
          </b-field>
          <b-field>
            <b-switch v-model="docDeclaration" v-on:input="switchDoc" type="is-info">Заявление-декларация</b-switch>
          </b-field>
        </b-field>

        <b-field grouped>
          <b-field>
            <b-button icon-left="download" type="is-ghost"></b-button>
          </b-field>
          <b-field>
            <b-switch v-model="docAct" v-on:input="switchDoc" type="is-info">Акт измерения</b-switch>
          </b-field>
        </b-field>
      </div>
      
      <b-button v-on:click="getAct"><strong>ТЕСТОВАЯ КНОПКА</strong></b-button>
      
    </div>

    <div class="centerBlock">

      <div v-if="docAny">
        <b-button type="is-warning" v-on:click="displayMod('displayModFlag')">{{ displayModBtnTitle }}</b-button>
        <div v-if="displayModFlag">
          <h1><strong>Внесённые изменения в конструкцию</strong></h1>
          <b-tabs>
            <b-tab-item label="Джиповый тюнинг">
              <b-field label="Передняя часть ТС">
                <b-switch v-model="powerBumperFront">Силовой бампер</b-switch>
                <b-switch v-model="jennyFront">Лебедка</b-switch>
                <b-switch v-model="protectiveArcFront">Защитная дуга</b-switch>
                <b-switch v-model="vizor">Козырёк</b-switch>
                <b-switch v-model="steps">Пороги</b-switch>
              </b-field>

              <b-field label="Задняя часть ТС">
                <b-switch v-model="powerBumperBack">Силовой бампер</b-switch>
                <b-switch v-model="jennyBack">Лебёдка</b-switch>
                <b-switch v-model="protectiveArcBack">Защитная дуга</b-switch>
                <b-switch v-model="wheelBracket">Кронштейн для запаски</b-switch>
                <b-switch v-model="wheelBracketDoor">Кронштейн для запаски на задней двери</b-switch>
                <b-switch v-model="kung">Кунг</b-switch>
              </b-field>

              <b-field label="Крыша">
                <b-switch v-model="carrier">Экспедиционный багажник</b-switch>
                <b-switch v-model="ladder">Лестница</b-switch>
                <b-switch v-model="manhole">Аварийно-вентиляционный люк</b-switch>
                <b-switch v-model="metalRoof">Металлическая крыша</b-switch>
              </b-field>

              <b-field label="Осветительное оборудование">
                <b-switch v-model="farLights">Доп.фары дальнего света</b-switch>
                <b-switch v-model="dayLights">Дневные ходовые огни</b-switch>
                <b-switch v-model="fogLights">Противотуманки</b-switch>
                <b-switch v-model="workLights">Рабочий свет</b-switch>
              </b-field>

              <b-field label="ДВС">
                <b-switch v-model="snorkel">Шноркель</b-switch>
                <b-switch v-model="engineProtection">Защита ДВС</b-switch>
              </b-field>

              <b-field label="Прочая внутрянка">
                <b-switch v-model="pullProtection">Защита рулевых тяг</b-switch>
                <b-switch v-model="transmissionProtection">Защита КПП</b-switch>
                <b-switch v-model="diskBrakesFront">Дисковые тормоза (перед)</b-switch>
                <b-switch v-model="diskBrakesBack">Дисковые тормоза (зад)</b-switch>
                <b-switch v-model="damper">Рулевой демпфер</b-switch>
                <b-switch v-model="waterBooster">Гидроусилитель руля</b-switch>
                <b-switch v-model="sleepingBag">Спальник</b-switch>
              </b-field>

              <b-field label="Лифт">
                <b-switch v-model="liftSpring">Пружины</b-switch>
                <b-switch v-model="liftSpacers">Проставки</b-switch>
              </b-field>

              <b-field label="Колёса">
                <b-switch v-model="biggerTires">Увеличенные шины</b-switch>
                <b-switch v-model="archExtenders">Расширители арок</b-switch>
              </b-field>
            </b-tab-item>

            <b-tab-item label="Гражданское переоборудование">
              <b-switch v-model="gasSet">ГБО (монтаж)</b-switch>
              <b-switch v-model="gasDelete">ГБО (демонтаж)</b-switch>
              <b-switch v-model="swapEngine">Смена ДВС</b-switch>
              <b-switch v-model="swapCategory">Смена категории</b-switch>
            </b-tab-item>

            <b-tab-item label="Спец.техника">
              <b-switch v-model="armorDelete">Снятие брони</b-switch>
            </b-tab-item>
          </b-tabs>
        </div>
      </div>

      <div v-if="docAny">
        <hr>
        <b-button v-on:click="displayMod('displayILFlag')" type="is-warning">{{ displayILBtnTitle }}</b-button>
        <div v-if="displayILFlag">
          <h1><strong>Данные по ИЛ и заключению</strong></h1>

          <b-field grouped>
            <b-field label="Испытательная лаборатория, выпустившая заключение" v-if="docDeclaration">
              <b-select v-model="nameLab" placeholder="Выберите ИЛ" expanded>
                <option value="AT">Академ-Тест</option>
                <option value="EGBO">Эксперт-ГБО</option>
                <option value="PA">Проф-Авто</option>
                <option value="IC">Испытательный центр</option>
              </b-select>
            </b-field>

            <b-field label="Номер заключения">
              <b-input v-model="finaleNumberLab" placeholder="Например: ПТЭАП01-38024"></b-input>
            </b-field>
          </b-field>
        </div>
      </div>

      <div v-if="docAny">
        <hr>
        <b-button v-on:click="displayMod('displayServiceFlag')" type="is-warning">{{ displayServiceBtnTitle }}</b-button>
        <div v-if="displayServiceFlag">
          <h1><strong>Данные по производителю работ и датам</strong></h1>
          <b-field label="Производитель работ (с полными ФИО)">
            <b-input v-model="nameService" placeholder="Например: ИП Васильев Павел Александрович"></b-input>
          </b-field>
          <b-field v-if="docDeclaration" label="Юридический адрес">
            <b-input v-model="entityAddressService" placeholder="Например: Челябинск, ул.Пекинская д.28"></b-input>
          </b-field>

          <b-field v-if="docDeclaration" label="Сертификат соответствия" grouped>
            <b-field label="Дата выдачи" expanded>
              <b-input v-model="certificateDateService" placeholder="Например: 12.03.1998"></b-input>
            </b-field>
            <b-field label="Номер сертификата" expanded>
              <b-input v-model="certificateNumberService" placeholder="Например: РОСС RU.318472.05СЯС1"></b-input>
            </b-field>
            <b-field label="Кем выдан" expanded>
              <b-input v-model="certificateAuthorService" placeholder="Например: органом по сертификации «Национальный научно-исследовательский институт экологии и сертификации»"></b-input>
            </b-field>
          </b-field>

          <b-field label="Дата и место проведения" grouped>
            <b-field v-if="docDeclaration" label="Дата выполнения работ" expanded>
              <b-input placeholder="Например: 12.03.1998"></b-input>
            </b-field>
            <b-field v-if="docAct" label="Дата проведения замеров" expanded>
              <b-input v-model="sampleCloseDateAct" placeholder="Например: 12.03.1998"></b-input>
            </b-field>
            <b-field v-if="docAct" label="Дата предоставления ТС" expanded>
              <b-input v-model="carGiveDateService" placeholder="Например: 12.03.1998"></b-input>
            </b-field>
          </b-field>

          <b-field v-if="docAct" grouped>
            <b-field label="Адрес ППТО" expanded>
              <b-input v-model="PPTOAddressAct" placeholder="Например: Челябинск, ул.Ленина д.17"></b-input>
            </b-field>
            <b-field label="ФИО сотрудника ППТО" expanded>
              <b-input v-model="namePPTOExpertAct" placeholder="Например: Ворошилов И.С."></b-input>
            </b-field>
            <b-field label="Номер акта проверки" expanded>
              <b-input v-model="numberAct" placeholder="Например: 271"></b-input>
            </b-field>
          </b-field>
        </div>
      </div>
      
      <div v-if="docAny">
        <hr>
        <b-button v-on:click="displayMod('displayAutoFlag')" type="is-warning">{{ displayAutoBtnTitle }}</b-button>
        <div v-if="displayAutoFlag">
          <div>
            
            <b-field grouped>
              <b-field label="Марка" expanded>
                <b-input v-model="brandCar" placeholder="Например: УАЗ"></b-input>
              </b-field>
              <b-field label="Модель" expanded>
                <b-input v-model="modelCar" placeholder="Например: Патриот"></b-input>
              </b-field>
              <b-field label="Цвет" expanded>
                <b-input v-model="colorCar" placeholder="Например: Чёрный"></b-input>
              </b-field>
              <b-field label="Гос.рег.знак" expanded>
                <b-input v-model="govRegNumCar" placeholder="Например: А459БВ774"></b-input>
              </b-field>
            </b-field>
            
            <b-field grouped>
              <b-field label="VIN" expanded>
                <b-input v-model="VINCar" placeholder="Например: XTT3166300И0013872"></b-input>
              </b-field>
              <b-field label="Номер шасси" v-if="docDeclaration" expanded>
                <b-input v-model="chassisNumberCar" placeholder="Например: 3166300E0575461"></b-input>
              </b-field>
              <b-field label="Номер кузова" v-if="docDeclaration" expanded>
                <b-input v-model="bodyNumberCar" placeholder="Например: 316302E0017590"></b-input>
              </b-field>
            </b-field>
            
            <b-field label="Данные по ДВС" grouped>
              <b-field label="Модель" expanded>
                <b-input v-model="modelEngine" placeholder="Например: 409050"></b-input>
              </b-field>
              <b-field label="Номер" expanded>
                <b-input v-model="numberEngine" placeholder="Например: E3022754"></b-input>
              </b-field>
              <b-field label="Тип" expanded>
                <b-input v-model="typeEngine" placeholder="Например: Бензиновый на бензине"></b-input>
              </b-field>
              <b-field label="Топливо" expanded>
                <b-input v-model="fuelEngine" placeholder="Например: Бензин/ГБО(СНГ)"></b-input>
              </b-field>
            </b-field>
            
            <b-field label="Результаты осмотра" v-if="docDeclaration" grouped>
              <b-field label="Вес ТС в снаряженном состоянии">
                <b-input v-model="weightInspection" placeholder="Например: 1459"></b-input>
              </b-field>
            </b-field>
          </div>
        </div>
      </div>
      
      <hr>
      
    </div>
    

    <div class="rightBlock">

    </div>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import {Component} from "vue-property-decorator";
import Act from "../../Config/Objects/Docs/Act";
import Laboratory from "../../Config/Objects/Items/Laboratory";
import Service from "../../Config/Objects/Items/Service";
import Car from "../../Config/Objects/Items/Car/Car";
import Engine from "../../Config/Objects/Items/Car/Parts/Engine";
import UpgradeTypes from "../../Config/Objects/Items/Car/UpgradeTypes";
import axios from "axios";
import actRequest from "../../Scripts/CreateDocuments/Act";

@Component
export default class CreateDocumentsPage extends Vue {
  name: string = "CreateDocumentsPage";
  displayModFlag: boolean = false;
  displayModBtnTitle: string = "Показать виды переоборудования";
  displayILFlag: boolean = false;
  displayILBtnTitle: string = "Показать данные по ИЛ";
  displayServiceFlag: boolean = false;
  displayServiceBtnTitle: string = "Показать данные по производителю работ";
  displayAutoFlag: boolean = false;
  displayAutoBtnTitle: string = "Показать данные по ТС";
  
  downloadLink: string = "";

  /* Переменные переключения выпускаемых док-ов */
  docAny: boolean = false;
  docDeclaration: boolean = false;
  docAct: boolean = false;

  /* Переменные свичей видов переоборудования */
  powerBumperFront: boolean = false;
  jennyFront: boolean = false;
  protectiveArcFront: boolean = false;
  vizor: boolean = false;
  steps: boolean = false;
  powerBumperBack: boolean = false;
  jennyBack: boolean = false;
  protectiveArcBack: boolean = false;
  wheelBracket: boolean = false;
  wheelBracketDoor: boolean = false;
  kung: boolean = false;
  carrier: boolean = false;
  ladder: boolean = false;
  manhole: boolean = false;
  metalRoof: boolean = false;
  farLights: boolean = false;
  dayLights: boolean = false;
  fogLights: boolean = false;
  workLights: boolean = false;
  snorkel: boolean = false;
  engineProtection: boolean = false;
  pullProtection: boolean = false;
  transmissionProtection: boolean = false;
  diskBrakesFront: boolean = false;
  diskBrakesBack: boolean = false;
  damper: boolean = false;
  waterBooster: boolean = false;
  sleepingBag: boolean = false;
  liftSpring: boolean = false;
  liftSpacers: boolean = false;
  biggerTires: boolean = false;
  archExtenders: boolean = false;

  gasSet: boolean = false;
  gasDelete: boolean = false;
  swapEngine: boolean = false;
  swapCategory: boolean = false;

  armorDelete: boolean = false;
  
  /* Переменные полей доков */

  nameLab: string = "";
  finaleNumberLab: string = "";
  nameService: string = "";
  entityAddressService: string = "";
  certificateDateService: string = "";
  certificateNumberService: string = "";
  certificateAuthorService: string = "";
  sampleCloseDateAct: string = "";
  carGiveDateService: string = "";
  PPTOAddressAct: string = "";
  namePPTOExpertAct: string = "";
  numberAct: string = "";
  brandCar: string = "";
  modelCar: string = "";
  colorCar: string = "";
  govRegNumCar: string = "";
  VINCar: string = "";
  chassisNumberCar: string = "";
  bodyNumberCar: string = "";
  modelEngine: string = "";
  numberEngine: string = "";
  typeEngine: string = "";
  fuelEngine: string = "";
  weightInspection: string = "";

  switchDoc(): void {
    if (this.docDeclaration || this.docAct)
      this.docAny = true;
    else this.docAny = false;
  }

  displayMod(flag: string): void {
    switch (flag) {
      case "displayModFlag":
        if (!this.displayModFlag) {
          this.displayModFlag = true;
          this.displayModBtnTitle = "Скрыть виды переоборудования"
        } else {
          this.displayModFlag = false;
          this.displayModBtnTitle = "Показать виды переоборудования"
        }
        break;
      case "displayILFlag":
        if (!this.displayILFlag) {
          this.displayILFlag = true;
          this.displayILBtnTitle = "Скрыть данные по ИЛ"
        } else {
          this.displayILFlag = false;
          this.displayILBtnTitle = "Показать данные по ИЛ"
        }
        break;
      case "displayServiceFlag":
        if (!this.displayServiceFlag) {
          this.displayServiceFlag = true;
          this.displayServiceBtnTitle = "Скрыть данные по производителю работ"
        } else {
          this.displayServiceFlag = false;
          this.displayServiceBtnTitle = "Показать данные по производителю работ"
        }
        break;
      case "displayAutoFlag":
        if (!this.displayAutoFlag) {
          this.displayAutoFlag = true;
          this.displayAutoBtnTitle = "Скрыть данные по ТС"
        } else {
          this.displayAutoFlag = false;
          this.displayAutoBtnTitle = "Показать данные по ТС"
        }
        break;
    }
  }

  async getAct(): Promise<void>
  {
    let act = new Act(
        new Laboratory(this.nameLab, this.finaleNumberLab), 
        new Service(this.nameService, this.entityAddressService, this.certificateDateService, 
        this.certificateNumberService, this.certificateAuthorService), 
        new Car (this.brandCar, this.modelCar, this.colorCar, this.govRegNumCar, this.VINCar,
        this.chassisNumberCar, this.bodyNumberCar, new Engine(this.modelEngine, this.numberEngine, this.typeEngine, this.fuelEngine),
        new UpgradeTypes()), this.numberAct, this.sampleCloseDateAct, this.carGiveDateService, this.PPTOAddressAct,
        this.namePPTOExpertAct);
    
    this.downloadLink = actRequest(act);
  }
    
    
}
</script>

<style>

.leftBlock, .rightBlock {
  width: 20%;
  height: 100%;
  float: left;
}

.centerBlock {
  width: 60%;
  height: 100%;
  float: left;
  margin: 0;
}

</style>