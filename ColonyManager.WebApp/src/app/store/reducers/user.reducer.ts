import { initialUserState, IUserState } from '../state/user.state';
import { SetLoggedUser } from '../actions/user.actions';
import { createReducer, on, Action } from '@ngrx/store';

const userReducer = createReducer(
  initialUserState,
  on(SetLoggedUser, (state, { payload }) => ({
    ...state,
    loggedUser: payload,
  })),
  on((state, { payload }) => ({ ...state, role: payload }))
);
export function userReducers(state: IUserState | undefined, action: Action) {
  return userReducer(state, action);
}
