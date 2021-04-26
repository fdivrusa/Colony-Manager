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
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
})
export class ComponentsRoutingModule {}
