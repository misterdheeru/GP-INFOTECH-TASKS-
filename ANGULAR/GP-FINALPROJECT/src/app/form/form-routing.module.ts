import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormComponent } from './form.component';
import { StudentsComponent } from './components/students/students.component';
import { CityComponent } from './components/city/city.component';
import { StatesComponent } from './components/states/states.component';
import { CountryComponent } from './components/country/country.component';

const routes: Routes = [{ path: 'app-students', component: StudentsComponent },{ path: 'app-country', component: CountryComponent },{ path: 'app-states', component: StatesComponent },{ path: 'app-city', component: CityComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FormRoutingModule { }
