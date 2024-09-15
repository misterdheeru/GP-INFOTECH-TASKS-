import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { WebpageRoutingModule } from './webpage-routing.module';
import { WebpageComponent } from './webpage.component';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { CenterComponent } from './components/center/center.component';
import { HomeComponent } from './components/home/home.component';



@NgModule({
  declarations: [
    WebpageComponent,
    HeaderComponent,
    FooterComponent,
    CenterComponent,
    HomeComponent
  ],
  imports: [
    CommonModule,
    WebpageRoutingModule,
 
  ],
  exports:[HeaderComponent,CenterComponent,FooterComponent]
})
export class WebpageModule { }
