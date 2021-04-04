import { NgModule } from '@angular/core';
import { StoreModule } from '@ngrx/store';
import * as fromApp from './app.reducers';

@NgModule({
  imports: [StoreModule.forFeature(fromApp.appFeatureKey, fromApp.appReducers)],
})
export class AllReducersModule {}
