import { initialAppState, IAppState } from '../state/app.state';
import { SetLoggedUser } from '../actions/app.actions';
import { createReducer, on, Action } from '@ngrx/store';

const appReducer = createReducer(
  initialAppState,
  on(SetLoggedUser, (state, { payload }) => ({
    ...state,
    loggedUser: payload,
  }))
);

export function appReducers(state: IAppState, action: Action) {
  return appReducer(state, action);
}

export const appFeatureKey = 'app';
