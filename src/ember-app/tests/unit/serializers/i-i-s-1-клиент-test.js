import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-1-клиент', 'Unit | Serializer | i-i-s-1-клиент', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-1-клиент',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'transform:i-i-s-1-способ1',
    'transform:i-i-s-1-тип-доставки',

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
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
