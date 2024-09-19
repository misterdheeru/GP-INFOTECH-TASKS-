import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormRoutingModule } from './form-routing.module';
import { FormComponent } from './form.component';
import { FormbuilderComponent } from './components/formbuilder/formbuilder.component';
import { ReactiveFormsModule } from '@angular/forms';
import { RectiveformsComponent } from './components/rectiveforms/rectiveforms.component';
 


@NgModule({
  declarations: [
    FormComponent,
    FormbuilderComponent,
    RectiveformsComponent,
 
  ],
  imports: [
    CommonModule,
    FormRoutingModule,
    ReactiveFormsModule
  ]
})
export class FormModule { }
