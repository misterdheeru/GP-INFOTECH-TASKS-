import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DataBindingExamplesComponent } from './components/data-binding-examples/data-binding-examples.component';

const routes: Routes = [{ path: 'app-data-binding-examples', component: DataBindingExamplesComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class DataBindingRoutingModule { }
