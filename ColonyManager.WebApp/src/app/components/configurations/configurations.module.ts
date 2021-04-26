import { NgModule } from '@angular/core';
import { SharedModule } from 'src/app/blocks/shared.module';
import { ConfigurationsRoutingModule } from './configurations-routing.module';

@NgModule({
  imports: [SharedModule, ConfigurationsRoutingModule],
})
export class ConfigurationsModule {}
