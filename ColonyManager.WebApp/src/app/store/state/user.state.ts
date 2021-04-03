import { User } from 'src/app/models/Account/User';

export interface IUserState {
  loggedUser: User;
}
export const initialUserState: IUserState = {
  loggedUser: new User(),
};
export function getInitialUserState(): IUserState {
  return initialUserState;
}
