import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import{FormComponent} from './form/form.component';
import{CompanylistComponent} from './companylist/companylist.component'
 
const routes: Routes = [
  {path:'form',component:FormComponent},
  {path:'companylist', component:CompanylistComponent},
  {path:'', component:CompanylistComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
