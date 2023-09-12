<template>
  <div>
    <div class="leftBlock">
      
      <b-field label="ФИО клиента">
        <b-input disabled></b-input>
      </b-field>

      <b-field label="Номер телефона">
        <b-input disabled></b-input>
      </b-field>

      <b-field label="Марка и модель ТС">
        <b-input disabled></b-input>
      </b-field>

      <b-field label="VIN">
        <b-input disabled></b-input>
      </b-field>
      
      <b-field>
        <b-button v-model="carInfo" @click="switchCard('carInfo')" type="is-warning" expanded>Данные по автомобилю</b-button>
      </b-field>
      <b-field>
        <b-button v-model="clientInfo" @click="switchCard('clientInfo')" type="is-warning" expanded>Данные по собственнику</b-button>
      </b-field>
      
      <hr>
      
      <b-field><h1><strong>Услуги</strong></h1></b-field>
      <b-field><b-switch>Регистрация переоборудования</b-switch></b-field>
      <b-field><b-switch>ЭПТС</b-switch></b-field>
      <b-field><b-switch>СБКТС</b-switch></b-field>
      <b-field><b-switch>Нанесение маркировки</b-switch></b-field>
      <b-field><b-switch>Иные услуги</b-switch></b-field>
      
    </div>

    <div class="centerBlock">
      
      <div v-if="mainCard">
        <b-field label="Новый комментарий"><b-input v-model="textOfNewComment"></b-input></b-field>
        <b-field><b-button @click="addNewComment" type="is-warning" expanded>Сохранить</b-button></b-field>
        
        <b-table
            :data="listOfComments">

          <b-table-column field="date" label="Дата и время" width="15%" sortable centered numeric v-slot="props">
            {{ props.row.date }}
          </b-table-column>

          <b-table-column field="text" label="Текст комментария" sortable centered v-slot="props">
            {{ props.row.text }}
          </b-table-column>

          <b-table-column field="author" label="Автор" width="10%" sortable centered v-slot="props">
            {{ props.row.author }}
          </b-table-column>
        </b-table>
      </div>
      
      <div v-if="carInfo">
        <b-tabs>
            <b-tab-item label="Документы на ТС">
              <b-tabs>
                <b-tab-item label="ПТС">
                  <b-field v-model="ptsNumber" label="Номер ПТС/ЭПТС"><b-input></b-input></b-field>
                  <b-field v-model="ptsDate" label="Дата выдачи ПТС/ЭПТС"><b-input></b-input></b-field>
                  <b-field v-model="VIN" label="VIN"><b-input></b-input></b-field>
                  <b-field v-model="carMark" label="Марка"><b-input></b-input></b-field>
                  <b-field v-model="carModel" label="Модель"><b-input></b-input></b-field>
                  <b-field v-model="carType" label="Тип ТС"><b-input></b-input></b-field>
                  <b-field v-model="carDrivingLicense" label="Категория прав"><b-input></b-input></b-field>
                  <b-field v-model="carCategory" label="Категория ТС по ТР/ТС"><b-input></b-input></b-field>
                  <b-field v-model="carYearProduction" label="Год выпуска"><b-input></b-input></b-field>
                  <b-field v-model="engineModel" label="Модель двигателя"><b-input></b-input></b-field>
                  <b-field v-model="engineNumber" label="Номер двигателя"><b-input></b-input></b-field>
                  <b-field v-model="chassisNumber" label="Номер шасси"><b-input></b-input></b-field>
                  <b-field v-model="bodyNumber" label="Номер кузова"><b-input></b-input></b-field>
                  <b-field v-model="enginePowerHorse" label="Мощность двигателя (л.с.)"><b-input></b-input></b-field>
                  <b-field v-model="enginePowerKwt" label="Мощность двигателя (кВт)"><b-input></b-input></b-field>
                  <b-field v-model="workVolume" label="Рабочий объём двигателя (см3)"><b-input></b-input></b-field>
                  <b-field v-model="engineType" label="Тип двигателя"><b-input></b-input></b-field>
                  <b-field v-model="ecoClass" label="Экологический класс"><b-input></b-input></b-field>
                  <b-field v-model="maxMass" label="Максимально разрешённая масса (кг)"><b-input></b-input></b-field>
                  <b-field v-model="massInDefault" label="Масса без нагрузки (кг)"><b-input></b-input></b-field>
                  <b-field v-model="carManufacturer" label="Изготовитель ТС"><b-input></b-input></b-field>
                  <b-field  v-model="otts" label="ОТТС"><b-input></b-input></b-field>
                </b-tab-item>
                <b-tab-item label="СТС">
                  <b-field v-model="stsNumber" label="Номер СТС"><b-input></b-input></b-field>
                  <b-field v-model="stsDate" label="Дата выдачи СТС"><b-input></b-input></b-field>
                  <b-field v-model="carNumber" label="Государственный регистрационный знак"><b-input></b-input></b-field>
                  <b-field v-model="carColor" label="Цвет"><b-input></b-input></b-field>
                </b-tab-item>
              </b-tabs>
            </b-tab-item>
          <b-tab-item label="Оказываемые услуги">
            <b-field>
              <b-switch v-model="changeConstructionService">Переоборудование</b-switch>
              <b-switch v-model="sbksService">СБКТС</b-switch>
              <b-switch v-model="eptsService">ЭПТС</b-switch>
            </b-field>
            <hr>
            <b-tabs>
            <b-tab-item label="Изменения в конструкции">
              <b-switch v-model="jeepTuningType">Джиповый тюнинг</b-switch>
              <b-switch v-model="truckTuningType">Грузовой тюнинг</b-switch>
              <b-switch v-model="changeCategoryTypeType">Смена категории/типа</b-switch>
              <b-switch v-model="otherType">Остальное</b-switch>
              <b-tabs>
                <b-tab-item label="Джиповый тюнинг">
                  <b-tabs>
                    <b-tab-item label="Перечень изменений">
                      <b-switch v-model="frontBumper">Передний силовой бампер</b-switch>
                      <b-switch v-model="rearBumper">Задний силовой бампер</b-switch>
                      <b-switch v-model="frontWinch">Электролебёдка на переднем бампере</b-switch>
                      <b-switch v-model="rearWinch">Электролебёдка на заднем бампере</b-switch>
                      <b-switch v-model="bumperWheelBracket">Кронштейн крепления запасного колеса (бампер)</b-switch>
                      <b-switch v-model="doorWheelBracket">Кронштейн крепления запасного колеса (дверь)</b-switch>
                      <b-switch v-model="trunk">Экспедиционный багажник</b-switch>
                      <b-switch v-model="ladder">Лестница для доступа к багажнику</b-switch>
                      <b-switch v-model="farLights">Доп.фары дальнего света</b-switch>
                      <b-switch v-model="dayLights">ДХО</b-switch>
                      <b-switch v-model="fogLights">ПТФ</b-switch>
                      <b-switch v-model="snorkel">Шноркель</b-switch>
                      <b-switch v-model="sills">Пороги</b-switch>
                      <b-switch v-model="kung">Кунг</b-switch>
                      <b-switch v-model="suspensionLiftSprings">Лифт подвески (пружины)</b-switch>
                      <b-switch v-model="suspensionLiftSpacers">Лифт подвески (проставки)</b-switch>
                      <b-switch v-model="biggerWheels">Колёса с шинами увеличенного размера</b-switch>
                      <b-switch v-model="archExtenders">Расширители колёсных арок</b-switch>
                      <b-switch v-model="workLights">Устройства освещения на месте стоянки (рабочий свет)</b-switch>
                      <b-switch v-model="rodProtection">Защита рулевых тяг</b-switch>
                      <b-switch v-model="engineProtection">Защита ДВС</b-switch>
                      <b-switch v-model="gearboxProtection">Защита КПП</b-switch>
                      <b-switch v-model="helmDamper">Рулевой демпфер</b-switch>
                      <b-switch v-model="helmBooster">ГУР</b-switch>
                      <b-switch v-model="frontDiskBrakes">Передние дисковые тормоза</b-switch>
                      <b-switch v-model="rearDiskBrakes">Задние дисковые тормоза</b-switch>
                      <b-switch v-model="frontProtectionArc">Защитная дуга под передним бампером</b-switch>
                      <b-switch v-model="rearProtectionArc">Защитная дуга под задним бампером</b-switch>
                      <b-switch v-model="insideProtectionArc">Защитные дуги в бортовом кузове</b-switch>
                      <b-switch v-model="protectiveVisor">Защитный козырёк</b-switch>
                      <b-switch v-model="hatch">Аварийно-вентиляционный люк</b-switch>
                      <b-switch v-model="sleepPlace">Спальное место</b-switch>
                      <b-switch v-model="metalRoof">Металлическая крыша</b-switch>
                    </b-tab-item>
                    <b-tab-item label="Информация по изменениям">
                      <b-field label="Массы">
                        <b-input v-model="massInDefaultAfter" placeholder="Масса без нагрузки (кг)" expanded></b-input>
                        <b-input v-model="equipmentMassAfter" placeholder="Снаряженная масса (кг)" expanded></b-input>
                      </b-field>
                      <b-field label="Габариты (мм)">
                        <b-input v-model="carLengthAfter" placeholder="Длина" expanded></b-input>
                        <b-input v-model="carWidthAfter" placeholder="Ширина" expanded></b-input>
                        <b-input v-model="carHeightAfter" placeholder="Высота" expanded></b-input>
                      </b-field>
                      <b-field label="Передний силовой бампер"><b-input v-model="frontBumperMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="Задний силовой бампер"><b-input v-model="rearBumperMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="Электролебёдка на переднем бампере"><b-input v-model="frontWinchMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="Электролебёдка на заднем бампере"><b-input v-model="rearWinchMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="Кронштейн крепления запасного колеса (дверь)"><b-input v-model="doorWheelBracketMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="Кронштейн крепления запасного колеса (бампер)"><b-input v-model="bumperWheelBracketMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="Экспедиционный багажник"><b-input v-model="trunkMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="Лестница для доступа к багажнику"><b-input v-model="ladderMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="Фары дальнего света"><b-input v-model="farLightsMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="ДХО"><b-input v-model="dayLightsMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="Противотуманные фары"><b-input v-model="fogLightsMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="Лифт подвески"><b-input v-model="suspensionLiftHeight" placeholder="Величина"></b-input></b-field>
                      <b-field label="Колёса с шинами увеличенного размера">
                        <b-input v-model="wheelsMark" placeholder="Марка"></b-input>
                        <b-input v-model="wheelsWidth" placeholder="Ширина шины"></b-input>
                        <b-input v-model="wheelsProfile" placeholder="Профиль шины"></b-input>
                        <b-input v-model="wheelsDiameter" placeholder="Диаметр диска"></b-input>
                      </b-field>
                      <b-field label="ГУР"><b-input v-model="helmBoosterMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="Защитная дуга под передним бампером"><b-input v-model="frontProtectionArcMark" placeholder="Марка"></b-input></b-field>
                      <b-field label="Защитная дуга под задним бампером"><b-input v-model="rearProtectionArcMark" placeholder="Марка"></b-input></b-field>
                    </b-tab-item>
                  </b-tabs>
                </b-tab-item>
                <b-tab-item label="Обычное переоборудование (общее)">
                  <b-switch v-model="installGboSng">Монтаж ГБО (СНГ)</b-switch>
                  <b-switch v-model="installGboKpg">Монтаж ГБО (КПГ)</b-switch>
                  <b-switch v-model="replaceEngine">Замена ДВС</b-switch>
                  <b-switch v-model="uninstallGbo">Демонтаж ГБО</b-switch>
                  <b-switch v-model="installStudyEquipment">Монтаж учебного оборудования</b-switch>
                  <b-switch v-model="uninstallStudyEquipment">Демонтаж учебного оборудования</b-switch>
                </b-tab-item>
                <b-tab-item label="Грузовые и автобусы">
                  <b-switch v-model="replaceCategoryDB">Смена категории D -> B</b-switch>
                  <b-switch v-model="replaceCategoryDC">Смена категории D -> C</b-switch>
                  <b-switch v-model="replaceCategoryCD">Смена категории C -> D</b-switch>
                  <b-switch v-model="flatbedIsothermalBody">Бортовая платформа -> изотермический фургон</b-switch>
                  <b-switch v-model="HOU">ХОУ</b-switch>
                </b-tab-item>
              </b-tabs>
            </b-tab-item>
            </b-tabs>
          </b-tab-item>
        </b-tabs>
      </div>
      
      <div v-if="clientInfo">
        <b-tabs>
          <b-tab-item label="Основные данные контакта">
            <b-field label="ФИО">
              <b-input placeholder="Фамилия" expanded></b-input >
              <b-input placeholder="Имя" expanded></b-input>
              <b-input placeholder="Отчество" expanded></b-input>
            </b-field>
            <b-field label="Номер телефона"><b-input placeholder="+79511155378" expanded></b-input></b-field>
            <b-field label="Серия и номер паспорта">
              <b-input placeholder="Серия" expanded></b-input>
              <b-input placeholder="Номер" expanded></b-input>
            </b-field>
            <b-field label="Кем выдан паспорт"><b-input expanded></b-input></b-field>
            <b-field label="Адрес по прописке"><b-input expanded></b-input></b-field>
          </b-tab-item>
        </b-tabs>
      </div>
      
    </div>
    
    <div class="rightBlock">
      <b-field><h1><strong>Шаблоны документов</strong></h1></b-field>
      <b-dropdown expanded>
        <template #trigger="{ active }">
          <b-button label="Переоборудование" type="is-warning" expanded></b-button>
        </template>
        
        <b-dropdown-item >Заявление-декларация</b-dropdown-item>
        <b-dropdown-item>Акт измерения</b-dropdown-item>
        <b-dropdown-item>Договор физ.лицо заключение</b-dropdown-item>
        <b-dropdown-item>Договор физ.лицо протокол</b-dropdown-item>
      </b-dropdown>
      <b-field><b-button label="Проверить сборку объекта" @click="testBuilding()"></b-button></b-field>
    </div>
    
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import {Component} from "vue-property-decorator";
import CommentInCard from "../../Config/Objects/SystemFrontObjects/CommentInCard";
import UpgradeTypes from "../../Config/Objects/Items/Ticket/Car/UpgradeTypes";
import TicketBuilder from "../../Config/Objects/SystemFrontObjects/TicketBuilder";

@Component
export default class TicketsPage extends Vue 
{
  name: string = "TicketPage";
  carInfo: boolean = false;
  clientInfo: boolean = false;
  mainCard: boolean = true;

  listOfComments: Array<CommentInCard> = [];
  textOfNewComment: string = "";

  data() {
    return {
      listOfComments: 
          [
            new CommentInCard('17.07.2023','Хуй1','Я'),
            new CommentInCard('18.07.2023','Хуй2','Я'),
            new CommentInCard('19.07.2023','Хуй3','Я')
          ]
    }
  }
  
  addNewComment()
  {
    this.listOfComments.push(new CommentInCard("20.07.2023", this.textOfNewComment, "Я"))
    this.textOfNewComment = "";
  }
  
  //** Документы на ТС **//
  //** Данные из ПТС **//
  ptsNumber: string = "";
  ptsDate: string = "";
  VIN: string = "";
  carMark: string = "";
  carModel: string = "";
  carType: string = "";
  carDrivingLicense: string = "";
  carCategory: string = "";
  carYearProduction: string = "";
  engineModel: string = "";
  engineNumber: string = "";
  chassisNumber: string = "";
  bodyNumber: string = "";
  enginePowerHorse: string = "";
  enginePowerKwt: string = "";
  workVolume: string = "";
  engineType: string = "";
  ecoClass: string = "";
  maxMass: string = "";
  massInDefault: string = "";
  carManufacturer: string = "";
  otts: string = "";
  
  //** Данные из СТС **//
  stsNumber: string = "";
  stsDate: string = "";
  carNumber: string = "";
  carColor: string = "";
  
  //** Виды услуг **//
  changeConstructionService: boolean = false;
  sbksService: boolean = false;
  eptsService: boolean = false;
  
  //** Виды переоборудования **//
  jeepTuningType: boolean = false;
  truckTuningType: boolean = false;
  changeCategoryTypeType: boolean = false;
  otherType: boolean = false;
  
  //** Флаги изменений в конструкции **//
  //** Джиповый тюинг
  frontBumper: boolean = false;
  rearBumper: boolean = false;
  frontWinch: boolean = false;
  rearWinch: boolean = false;
  bumperWheelBracket: boolean = false;
  doorWheelBracket: boolean = false;
  trunk: boolean = false;
  ladder: boolean = false;
  farLights: boolean = false;
  dayLights: boolean = false;
  fogLights: boolean = false;
  snorkel: boolean = false;
  sills: boolean = false;
  kung: boolean = false;
  suspensionLiftSprings: boolean = false;
  suspensionLiftSpacers: boolean = false;
  biggerWheels: boolean = false;
  archExtenders: boolean = false;
  workLights: boolean = false;
  rodProtection: boolean = false;
  engineProtection: boolean = false;
  gearboxProtection: boolean = false;
  helmDamper: boolean = false;
  helmBooster: boolean = false;
  frontDiskBrakes: boolean = false;
  rearDiskBrakes: boolean = false;
  frontProtectionArc: boolean = false;
  rearProtectionArc: boolean = false;
  insideProtectionArc: boolean = false;
  protectiveVisor: boolean = false;
  hatch: boolean = false;
  sleepPlace: boolean = false;
  metalRoof: boolean = false;
  
  //** Грузовой тюнинг
  HOU: boolean = false;
  
  //** Смена категории/типа
  replaceCategoryDB: boolean = false;
  replaceCategoryDC: boolean = false;
  replaceCategoryCD: boolean = false;
  flatbedIsothermalBody: boolean = false;
  
  //** Остальное
  installGboSng: boolean = false;
  installGboKpg: boolean = false;
  replaceEngine: boolean = false;
  uninstallGbo: boolean = false;
  installStudyEquipment: boolean = false;
  uninstallStudyEquipment: boolean = false;
  
  
  //** Доп.информация по изменениям **//
  //** Джиповый тюнинг **//
  massInDefaultAfter: string = "";
  equipmentMassAfter: string = "";
  carLengthAfter: string = "";
  carWidthAfter: string = "";
  carHeightAfter: string = "";
  frontBumperMark: string = "";
  rearBumperMark: string = "";
  frontWinchMark: string = "";
  rearWinchMark: string = "";
  doorWheelBracketMark: string = "";
  bumperWheelBracketMark: string = "";
  trunkMark: string = "";
  ladderMark: string = "";
  farLightsMark: string = "";
  dayLightsMark: string = "";
  fogLightsMark: string = "";
  suspensionLiftHeight: string = "";
  wheelsMark: string = "";
  wheelsWidth: string = "";
  wheelsProfile: string = "";
  wheelsDiameter: string = "";
  helmBoosterMark: string = "";
  frontProtectionArcMark: string = "";
  rearProtectionArcMark: string = "";
  
  //** Передача данных в билдер объекта карточки **//
  
  //** Объекты предварительной сборки карточки **//
  jeepTuningChanges: UpgradeTypes = new UpgradeTypes(["null"], "null");
  truckTuningChanges: UpgradeTypes = new UpgradeTypes(["null"], "null");
  changeCategoryTypeChanges: UpgradeTypes = new UpgradeTypes(["null"], "null");
  otherChanges: UpgradeTypes = new UpgradeTypes(["null"], "null");
  //**//

  testBuilding()
  {
    if (this.changeConstructionService)
    {
      if (this.jeepTuningType)
      {
        this.jeepTuningChanges = TicketBuilder.buildJeepTuningChanges
        (
            this.frontBumper, this.rearBumper, this.frontWinch, this.rearWinch, this.bumperWheelBracket, this.doorWheelBracket, this.trunk,
            this.ladder, this.farLights, this.dayLights, this.fogLights, this.snorkel, this.sills, this.kung, this.suspensionLiftSprings,
            this.suspensionLiftSpacers, this.biggerWheels, this.archExtenders, this.workLights, this.rodProtection,
            this.engineProtection, this.gearboxProtection, this.helmDamper, this.helmBooster, this.frontDiskBrakes, this.rearDiskBrakes,
            this.frontProtectionArc, this.rearProtectionArc, this.insideProtectionArc, this.protectiveVisor, this.hatch, this.sleepPlace, this.metalRoof
        );
        console.log("Сборка jeepTuningChanges успешно произведена!")
      }
      if (this.truckTuningType)
      {
        this.truckTuningChanges = TicketBuilder.buildTruckTuningChanges
        (
            this.HOU
        );
        console.log("Сборка truckTuningChanges успешно произведена!")
      }
      if (this.changeCategoryTypeType)
      {
        this.changeCategoryTypeChanges = TicketBuilder.buildChangeCategoryTypeChanges
        (
            this.replaceCategoryDB, this.replaceCategoryDC, this.replaceCategoryCD, this.flatbedIsothermalBody
        );
        console.log("Сборка changeCategoryTypeChanges успешно произведена!")
      }
      if (this.otherType)
      {
        this.otherChanges = TicketBuilder.buildOtherChanges
        (
            this.installGboSng, this.installGboKpg, this.replaceEngine, this.uninstallGbo, this.installStudyEquipment,
            this.uninstallStudyEquipment
        );
        console.log("Сборка otherChanges успешно произведена!")
      }
    }
  }
  
  switchCard(input: string): void
  {
    switch (input) 
    {
      case 'carInfo': 
      {
        if (this.carInfo)
        {
          this.carInfo = false;
          this.clientInfo = false;
          this.mainCard = true;
        }
        else
        {
          this.carInfo = true;
          this.clientInfo = false;
          this.mainCard = false;
        }
        break;
      }
      case 'clientInfo':
      {
        if (this.clientInfo)
        {
          this.clientInfo = false;
          this.carInfo = false;
          this.mainCard = true;
        }
        else
        {
          this.clientInfo = true;
          this.carInfo = false;
          this.mainCard = false;
        }
        break;
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