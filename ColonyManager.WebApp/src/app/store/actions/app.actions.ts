import { createAction, props } from '@ngrx/store';
import { User } from 'src/app/models/Account/User';

export const SetLoggedUser = createAction(
  '[App] Set current logged user',
  props<{ payload: User }>()
);
