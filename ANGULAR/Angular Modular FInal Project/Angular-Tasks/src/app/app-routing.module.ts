import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  
  { path: 'Auth', loadChildren: () => import('./auth/auth.module').then(m => m.AuthModule) },
  { path: 'webpage', loadChildren: () => import('./webpage/webpage.module').then(m => m.WebpageModule) },
  { path: 'DataBinding', loadChildren: () => import('./data-binding/data-binding.module').then(m => m.DataBindingModule) },
  
  { path: 'Form', loadChildren: () => import('./form/form.module').then(m => m.FormModule) },
  
  { path: 'StudentsCrud', loadChildren: () => import('./students-crud/students-crud.module').then(m => m.StudentsCrudModule) }
  
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
