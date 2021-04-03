import { IStoreState } from '../state/store.state';
import { createSelector, select } from '@ngrx/store';
import { IUserState } from './../state/user.state';

const selectApp = (state: IStoreState) => state.user;

export const loggedUserSelector = createSelector(
  selectApp,
  (state: IUserState) => state.loggedUser
);
