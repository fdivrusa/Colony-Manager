import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { ConfigurationsComponent } from './configurations.component';
import { ConfigurationItemsComponent } from './configuration-items/configuration-items.component';

const routes: Routes = [
  {
    path: '',
    component: ConfigurationsComponent,
    children: [
      {
        path: 'details/:id',
        component: ConfigurationItemsComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ConfigurationsRoutingModule {}
