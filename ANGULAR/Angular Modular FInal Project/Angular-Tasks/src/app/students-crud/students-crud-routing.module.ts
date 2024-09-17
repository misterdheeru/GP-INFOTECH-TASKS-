import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StudentsCrudComponent } from './students-crud.component';
import { CountryComponent } from './components/country/country.component';

const routes: Routes = [{ path: 'app-country', component: CountryComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StudentsCrudRoutingModule { }
