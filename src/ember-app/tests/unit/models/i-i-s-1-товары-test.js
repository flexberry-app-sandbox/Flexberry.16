import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-1-товары', 'Unit | Model | i-i-s-1-товары', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-1-заказ',
    'model:i-i-s-1-клиент',
    'model:i-i-s-1-менеджер',
    'model:i-i-s-1-оплата',
    'model:i-i-s-1-поставщик',
    'model:i-i-s-1-производитель',
    'model:i-i-s-1-товар',
    'model:i-i-s-1-товары',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
