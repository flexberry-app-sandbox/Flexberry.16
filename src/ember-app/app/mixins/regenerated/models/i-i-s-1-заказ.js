import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  дата: DS.attr('date'),
  доставка: DS.attr('i-i-s-1-тип-доставки'),
  номерЗаказа: DS.attr('number'),
  клиент: DS.belongsTo('i-i-s-1-клиент', { inverse: null, async: false }),
  менеджер: DS.belongsTo('i-i-s-1-менеджер', { inverse: null, async: false }),
  товар: DS.belongsTo('i-i-s-1-товар', { inverse: null, async: false }),
  товары: DS.hasMany('i-i-s-1-товары', { inverse: 'заказ', async: false }),
  оплата: DS.hasMany('i-i-s-1-оплата', { inverse: 'заказ', async: false })
});

export let ValidationRules = {
  дата: {
    descriptionKey: 'models.i-i-s-1-заказ.validations.дата.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  доставка: {
    descriptionKey: 'models.i-i-s-1-заказ.validations.доставка.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  номерЗаказа: {
    descriptionKey: 'models.i-i-s-1-заказ.validations.номерЗаказа.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  клиент: {
    descriptionKey: 'models.i-i-s-1-заказ.validations.клиент.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  менеджер: {
    descriptionKey: 'models.i-i-s-1-заказ.validations.менеджер.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  товар: {
    descriptionKey: 'models.i-i-s-1-заказ.validations.товар.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  товары: {
    descriptionKey: 'models.i-i-s-1-заказ.validations.товары.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
  оплата: {
    descriptionKey: 'models.i-i-s-1-заказ.validations.оплата.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ЗаказE', 'i-i-s-1-заказ', {
    номерЗаказа: attr('Номер заказа', { index: 0 }),
    доставка: attr('Доставка', { index: 1 }),
    дата: attr('Дата', { index: 2 })
  });

  modelClass.defineProjection('ЗаказL', 'i-i-s-1-заказ', {
    номерЗаказа: attr('Номер заказа', { index: 0 }),
    доставка: attr('Доставка', { index: 1 }),
    дата: attr('Дата', { index: 2 })
  });
};
