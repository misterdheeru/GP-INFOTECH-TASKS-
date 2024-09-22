import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [{ path: 'page', loadChildren: () => import('./page/page.module').then(m => m.PageModule) }, { path: 'Form', loadChildren: () => import('./form/form.module').then(m => m.FormModule) }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
