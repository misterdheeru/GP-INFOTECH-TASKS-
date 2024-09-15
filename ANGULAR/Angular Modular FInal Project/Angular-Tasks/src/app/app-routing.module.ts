import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  
  { path: 'Auth', loadChildren: () => import('./auth/auth.module').then(m => m.AuthModule) },
  { path: 'webpage', loadChildren: () => import('./webpage/webpage.module').then(m => m.WebpageModule) },
  { path: 'DataBinding', loadChildren: () => import('./data-binding/data-binding.module').then(m => m.DataBindingModule) }
  
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
