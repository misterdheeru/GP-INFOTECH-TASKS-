import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { StudentsCrudRoutingModule } from './students-crud-routing.module';
import { StudentsCrudComponent } from './students-crud.component';
import { CountryComponent } from './components/country/country.component';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    StudentsCrudComponent,
    CountryComponent
  ],
  imports: [
    CommonModule,
    StudentsCrudRoutingModule,
    ReactiveFormsModule
  ]
})
export class StudentsCrudModule { }
