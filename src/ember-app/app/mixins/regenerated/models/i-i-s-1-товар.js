import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  изображение: DS.attr('string'),
  наименование: DS.attr('string'),
  свойства: DS.attr('string'),
  поставщик: DS.belongsTo('i-i-s-1-поставщик', { inverse: null, async: false }),
  производитель: DS.belongsTo('i-i-s-1-производитель', { inverse: null, async: false })
});

export let ValidationRules = {
  изображение: {
    descriptionKey: 'models.i-i-s-1-товар.validations.изображение.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  наименование: {
    descriptionKey: 'models.i-i-s-1-товар.validations.наименование.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  свойства: {
    descriptionKey: 'models.i-i-s-1-товар.validations.свойства.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  поставщик: {
    descriptionKey: 'models.i-i-s-1-товар.validations.поставщик.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  производитель: {
    descriptionKey: 'models.i-i-s-1-товар.validations.производитель.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ТоварE', 'i-i-s-1-товар', {
    свойства: attr('Свойства', { index: 0 }),
    наименование: attr('Наименование', { index: 1 }),
    изображение: attr('Изображение', { index: 2 })
  });

  modelClass.defineProjection('ТоварL', 'i-i-s-1-товар', {
    свойства: attr('Свойства', { index: 0 }),
    наименование: attr('Наименование', { index: 1 }),
    изображение: attr('Изображение', { index: 2 })
  });
};
