import { User } from 'src/app/models/Account/User';

export interface IAppState {
  loggedUser: User;
}

export const initialAppState: IAppState = {
  loggedUser: new User(),
};

export function getInitialAppState(): IAppState {
  return initialAppState;
}
