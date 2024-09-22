import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FormRoutingModule } from './form-routing.module';
import { FormComponent } from './form.component';
import { StudentsComponent } from './components/students/students.component';
import { CountryComponent } from './components/country/country.component';
import { CityComponent } from './components/city/city.component';
import { StatesComponent } from './components/states/states.component';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatButtonModule } from '@angular/material/button';
import { MatDividerModule } from '@angular/material/divider';
import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';


@NgModule({
  declarations: [
    FormComponent,
    StudentsComponent,
    CountryComponent,
    CityComponent,
    StatesComponent
  ],
  imports: [
    CommonModule,
    FormRoutingModule,
    MatSlideToggleModule,
    MatButtonModule,
    MatDividerModule,
    MatIconModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule

  ]
})
export class FormModule { }
