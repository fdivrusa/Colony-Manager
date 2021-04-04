import { initialAppState, IAppState } from './app.state';

export interface IStoreState {
  app: IAppState;
}

export const initialStoreState: IStoreState = {
  app: initialAppState,
};

export function getInitialStoreState(): IStoreState {
  return initialStoreState;
}
