import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { CapitalsComponent } from './components/capitals/capitals.component';
import { ExpensesComponent } from './components/expenses/expenses.component';

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
  {
    path: 'expenses',
    component: ExpensesComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [ RouterModule ]
})
export class AppRoutingModule { }
