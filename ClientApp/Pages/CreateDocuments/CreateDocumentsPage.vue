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
      
    </div>

    <div class="centerBlock">

      <div v-if="docAny">
        <b-button type="is-warning" v-on:click="displayMod('displayModFlag')">{{ displayModBtnTitle }}</b-button>
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
              <b-select placeholder="Выберите ИЛ" expanded>
                <option value="AT">Академ-Тест</option>
                <option value="EGBO">Эксперт-ГБО</option>
                <option value="PA">Проф-Авто</option>
                <option value="IC">Испытательный центр</option>
              </b-select>
            </b-field>

            <b-field label="Номер заключения">
              <b-input placeholder="Например: ПТЭАП01-38024"></b-input>
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
            <b-input placeholder="Например: ИП Васильев Павел Александрович"></b-input>
          </b-field>
          <b-field v-if="docDeclaration" label="Юридический адрес">
            <b-input placeholder="Например: Челябинск, ул.Пекинская д.28"></b-input>
          </b-field>

          <b-field v-if="docDeclaration" label="Сертификат соответствия" grouped>
            <b-field label="Дата выдачи" expanded>
              <b-input placeholder="Например: 12.03.1998"></b-input>
            </b-field>
            <b-field label="Номер сертификата" expanded>
              <b-input placeholder="Например: РОСС RU.318472.05СЯС1"></b-input>
            </b-field>
            <b-field label="Кем выдан" expanded>
              <b-input
                  placeholder="Например: органом по сертификации «Национальный научно-исследовательский институт экологии и сертификации»"></b-input>
            </b-field>
          </b-field>

          <b-field label="Дата и место проведения" grouped>
            <b-field v-if="docDeclaration" label="Дата выполнения работ" expanded>
              <b-input placeholder="Например: 12.03.1998"></b-input>
            </b-field>
            <b-field v-if="docAct" label="Дата проведения замеров" expanded>
              <b-input placeholder="Например: 12.03.1998"></b-input>
            </b-field>
            <b-field v-if="docAct" label="Дата предоставления ТС" expanded>
              <b-input placeholder="Например: 12.03.1998"></b-input>
            </b-field>
          </b-field>

          <b-field v-if="docAct" grouped>
            <b-field label="Адрес ППТО" expanded>
              <b-input placeholder="Например: Челябинск, ул.Ленина д.17"></b-input>
            </b-field>
            <b-field label="ФИО сотрудника ППТО" expanded>
              <b-input placeholder="Например: Ворошилов И.С."></b-input>
            </b-field>
            <b-field label="Номер акта проверки" expanded>
              <b-input placeholder="Например: 271"></b-input>
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
              <b-field label="Марка, модель" expanded>
                <b-input placeholder="Например: УАЗ, Патриот"></b-input>
              </b-field>
              <b-field label="Цвет" expanded>
                <b-input placeholder="Например: Чёрный"></b-input>
              </b-field>
              <b-field label="Гос.рег.знак" expanded>
                <b-input placeholder="Например: А459БВ774"></b-input>
              </b-field>
            </b-field>
            
            <b-field grouped>
              <b-field label="VIN" expanded>
                <b-input placeholder="Например: XTT3166300И0013872"></b-input>
              </b-field>
              <b-field label="Номер шасси" v-if="docDeclaration" expanded>
                <b-input placeholder="Например: 3166300E0575461"></b-input>
              </b-field>
              <b-field label="Номер кузова" v-if="docDeclaration" expanded>
                <b-input placeholder="Например: 316302E0017590"></b-input>
              </b-field>
            </b-field>
            
            <b-field label="Данные по ДВС" grouped>
              <b-field label="Модель" expanded>
                <b-input placeholder="Например: 409050"></b-input>
              </b-field>
              <b-field label="Номер" expanded>
                <b-input placeholder="Например: E3022754"></b-input>
              </b-field>
              <b-field label="Тип" expanded>
                <b-input placeholder="Например: Бензиновый на бензине"></b-input>
              </b-field>
              <b-field label="Топливо" expanded>
                <b-input placeholder="Например: Бензин/ГБО(СНГ)"></b-input>
              </b-field>
            </b-field>
            
            <b-field label="Результаты осмотра" v-if="docDeclaration" grouped>
              <b-field label="Вес ТС в снаряженном состоянии">
                <b-input placeholder="Например: 1459"></b-input>
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

  docAny: boolean = false;
  docDeclaration: boolean = false;
  docAct: boolean = false;

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