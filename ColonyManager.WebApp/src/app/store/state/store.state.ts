import { initialUserState, IUserState } from './user.state';

export interface IStoreState {
  user: IUserState;
}

export const initialStoreState: IStoreState = {
  user: initialUserState,
};

export function getInitialStoretate(): IStoreState {
  return initialStoreState;
}
