import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SharedModule } from 'src/app/blocks/shared.module';
import { ConfigurationsRoutingModule } from './configurations-routing.module';
import { ConfigurationsComponent } from './configurations.component';
import { ConfigurationItemsComponent } from './configuration-items/configuration-items.component';

@NgModule({
  declarations: [ConfigurationsComponent, ConfigurationItemsComponent],
  imports: [SharedModule, CommonModule, ConfigurationsRoutingModule],
})
export class ConfigurationsModule {}
