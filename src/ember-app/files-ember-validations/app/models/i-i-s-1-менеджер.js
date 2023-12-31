import {
  defineNamespace,
  defineProjections,
  Model as МенеджерMixin
} from '../mixins/regenerated/models/i-i-s-1-менеджер';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(МенеджерMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
