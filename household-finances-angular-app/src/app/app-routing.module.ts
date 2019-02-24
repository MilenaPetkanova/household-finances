import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { CapitalsComponent } from './components/capitals/capitals.component';

const routes: Routes = [
  // {
  //   path: '',
  //   redirectTo: '/overview',
  //   pathMatch: 'full'
  // },
  {
    path: 'capitals',
    component: CapitalsComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [ RouterModule ]
})
export class AppRoutingModule { }
