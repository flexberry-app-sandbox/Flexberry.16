import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/en/translations';

import IIS1ЗаказLForm from './forms/i-i-s-1-заказ-l';
import IIS1КлиентLForm from './forms/i-i-s-1-клиент-l';
import IIS1МенеджерLForm from './forms/i-i-s-1-менеджер-l';
import IIS1ПоставщикLForm from './forms/i-i-s-1-поставщик-l';
import IIS1ПроизводительLForm from './forms/i-i-s-1-производитель-l';
import IIS1ТоварLForm from './forms/i-i-s-1-товар-l';
import IIS1ЗаказEForm from './forms/i-i-s-1-заказ-e';
import IIS1КлиентEForm from './forms/i-i-s-1-клиент-e';
import IIS1МенеджерEForm from './forms/i-i-s-1-менеджер-e';
import IIS1ПоставщикEForm from './forms/i-i-s-1-поставщик-e';
import IIS1ПроизводительEForm from './forms/i-i-s-1-производитель-e';
import IIS1ТоварEForm from './forms/i-i-s-1-товар-e';
import IIS1ЗаказModel from './models/i-i-s-1-заказ';
import IIS1КлиентModel from './models/i-i-s-1-клиент';
import IIS1МенеджерModel from './models/i-i-s-1-менеджер';
import IIS1ОплатаModel from './models/i-i-s-1-оплата';
import IIS1ПоставщикModel from './models/i-i-s-1-поставщик';
import IIS1ПроизводительModel from './models/i-i-s-1-производитель';
import IIS1ТоварModel from './models/i-i-s-1-товар';
import IIS1ТоварыModel from './models/i-i-s-1-товары';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-1-заказ': IIS1ЗаказModel,
    'i-i-s-1-клиент': IIS1КлиентModel,
    'i-i-s-1-менеджер': IIS1МенеджерModel,
    'i-i-s-1-оплата': IIS1ОплатаModel,
    'i-i-s-1-поставщик': IIS1ПоставщикModel,
    'i-i-s-1-производитель': IIS1ПроизводительModel,
    'i-i-s-1-товар': IIS1ТоварModel,
    'i-i-s-1-товары': IIS1ТоварыModel
  },

  'application-name': '1',

  forms: {
    loading: {
      'spinner-caption': 'Loading stuff, please wait for a moment...'
    },
    index: {
      greeting: 'Welcome to ember-flexberry test stand!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Menu'
          },
          'user-settings-service-checkbox': {
            caption: 'Use service to save user settings'
          },
          'show-menu': {
            caption: 'Show menu'
          },
          'hide-menu': {
            caption: 'Hide menu'
          },
          'language-dropdown': {
            caption: 'Application language',
            placeholder: 'Choose language'
          }
        },
        login: {
          caption: 'Login'
        },
        logout: {
          caption: 'Logout'
        }
      },

      footer: {
        'application-name': '1',
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: '1',
          title: '1'
        },
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        },
        index: {
          caption: 'Home',
          title: ''
        },
        'справочник-по-товарам': {
          caption: 'Справочник по товарам',
          title: 'Справочник по товарам',
          'i-i-s-1-производитель-l': {
            caption: 'Производитель',
            title: ''
          },
          'i-i-s-1-поставщик-l': {
            caption: 'Поставщик',
            title: ''
          },
          'i-i-s-1-товар-l': {
            caption: 'Товар',
            title: ''
          }
        },
        заказ: {
          caption: 'Заказ',
          title: 'Заказ',
          'i-i-s-1-заказ-l': {
            caption: 'Заказ',
            title: ''
          }
        },
        клиенты: {
          caption: 'Клиенты',
          title: 'Клиенты',
          'i-i-s-1-клиент-l': {
            caption: 'Клиент',
            title: ''
          }
        },
        менеджеры: {
          caption: 'Менеджеры',
          title: 'Менеджеры',
          'i-i-s-1-менеджер-l': {
            caption: 'Менеджер',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Save operation succeed',
      'save-success-message': 'Object saved',
      'save-error-message-caption': 'Save operation failed',
      'delete-success-message-caption': 'Delete operation succeed',
      'delete-success-message': 'Object deleted',
      'delete-error-message-caption': 'Delete operation failed'
    },
    'i-i-s-1-заказ-l': IIS1ЗаказLForm,
    'i-i-s-1-клиент-l': IIS1КлиентLForm,
    'i-i-s-1-менеджер-l': IIS1МенеджерLForm,
    'i-i-s-1-поставщик-l': IIS1ПоставщикLForm,
    'i-i-s-1-производитель-l': IIS1ПроизводительLForm,
    'i-i-s-1-товар-l': IIS1ТоварLForm,
    'i-i-s-1-заказ-e': IIS1ЗаказEForm,
    'i-i-s-1-клиент-e': IIS1КлиентEForm,
    'i-i-s-1-менеджер-e': IIS1МенеджерEForm,
    'i-i-s-1-поставщик-e': IIS1ПоставщикEForm,
    'i-i-s-1-производитель-e': IIS1ПроизводительEForm,
    'i-i-s-1-товар-e': IIS1ТоварEForm
  },

});

export default translations;
