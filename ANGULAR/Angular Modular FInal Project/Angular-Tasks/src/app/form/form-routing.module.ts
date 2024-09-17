import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormComponent } from './form.component';
import { FormsBulderComponent } from './components/forms-bulder/forms-bulder.component';

const routes: Routes = [{ path: 'app-forms-bulder', component: FormsBulderComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FormRoutingModule { }
