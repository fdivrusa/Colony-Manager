import { IStoreState } from '../state/store.state';
import { createSelector, select } from '@ngrx/store';
import { IAppState } from '../state/app.state';

const selectApp = (state: IStoreState) => state.app;

export const loggedUserSelector = createSelector(
  selectApp,
  (state: IAppState) => state.loggedUser
);
