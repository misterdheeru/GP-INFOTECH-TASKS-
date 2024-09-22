import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PageRoutingModule } from './page-routing.module';
import { PageComponent } from './page.component';
import { HeaderComponent } from './components/header/header.component';
import { HomeComponent } from './components/home/home.component';
import { FooterComponent } from './components/footer/footer.component';
import { RouterLink } from '@angular/router';


@NgModule({
  declarations: [
    PageComponent,
    HeaderComponent,
    HomeComponent,
    FooterComponent

  ],
  imports: [
    CommonModule,
    PageRoutingModule,
    RouterLink
  
  ],
  exports:[HeaderComponent,FooterComponent]
})
export class PageModule { }
