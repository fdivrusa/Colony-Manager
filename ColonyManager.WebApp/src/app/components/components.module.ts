import { NgModule } from '@angular/core';
import { SharedModule } from '../blocks/shared.module';
import { ComponentsRoutingModule } from './components-routing.module';

@NgModule({
  imports: [SharedModule, ComponentsRoutingModule],
})
export class ComponentsModule {}
