import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'configurations',
    loadChildren: () =>
      import('./configurations/configurations.module').then(
        (m) => m.ConfigurationsModule
      ),
  },

  {
    path: 'peoples',
    loadChildren: () =>
      import('./peoples/peoples.module').then((m) => m.PeoplesModule),
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ComponentsRoutingModule {}
