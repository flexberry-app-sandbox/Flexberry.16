import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-1-заказ-l');
  this.route('i-i-s-1-заказ-e',
  { path: 'i-i-s-1-заказ-e/:id' });
  this.route('i-i-s-1-заказ-e.new',
  { path: 'i-i-s-1-заказ-e/new' });
  this.route('i-i-s-1-клиент-l');
  this.route('i-i-s-1-клиент-e',
  { path: 'i-i-s-1-клиент-e/:id' });
  this.route('i-i-s-1-клиент-e.new',
  { path: 'i-i-s-1-клиент-e/new' });
  this.route('i-i-s-1-менеджер-l');
  this.route('i-i-s-1-менеджер-e',
  { path: 'i-i-s-1-менеджер-e/:id' });
  this.route('i-i-s-1-менеджер-e.new',
  { path: 'i-i-s-1-менеджер-e/new' });
  this.route('i-i-s-1-поставщик-l');
  this.route('i-i-s-1-поставщик-e',
  { path: 'i-i-s-1-поставщик-e/:id' });
  this.route('i-i-s-1-поставщик-e.new',
  { path: 'i-i-s-1-поставщик-e/new' });
  this.route('i-i-s-1-производитель-l');
  this.route('i-i-s-1-производитель-e',
  { path: 'i-i-s-1-производитель-e/:id' });
  this.route('i-i-s-1-производитель-e.new',
  { path: 'i-i-s-1-производитель-e/new' });
  this.route('i-i-s-1-товар-l');
  this.route('i-i-s-1-товар-e',
  { path: 'i-i-s-1-товар-e/:id' });
  this.route('i-i-s-1-товар-e.new',
  { path: 'i-i-s-1-товар-e/new' });
});

export default Router;
