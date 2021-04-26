import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { ConfigurationsComponent } from './configurations.component';

const routes: Routes = [
  {
    path: '',
    component: ConfigurationsComponent,
    children: [],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ConfigurationsRoutingModule {}
