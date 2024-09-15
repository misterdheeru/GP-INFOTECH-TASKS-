import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DataBindingRoutingModule } from './data-binding-routing.module';
import { DataBindingComponent } from './data-binding.component';
import { DataBindingExamplesComponent } from './components/data-binding-examples/data-binding-examples.component';


@NgModule({
  declarations: [
    DataBindingComponent,
    DataBindingExamplesComponent
  ],
  imports: [
    CommonModule,
    DataBindingRoutingModule
  ]
})
export class DataBindingModule { }
