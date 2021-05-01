import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SharedModule } from 'src/app/blocks/shared.module';
import { ConfigurationsRoutingModule } from './configurations-routing.module';
import { ConfigurationsComponent } from './configurations.component';

@NgModule({
  declarations: [ConfigurationsComponent],
  imports: [SharedModule, CommonModule, ConfigurationsRoutingModule],
})
export class ConfigurationsModule {}
