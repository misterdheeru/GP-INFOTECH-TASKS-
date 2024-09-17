import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { WebpageModule } from "./webpage/webpage.module";
import { DataBindingModule } from './data-binding/data-binding.module';
import { AuthModule } from './auth/auth.module';
import { RouterLink } from '@angular/router';
import { provideHttpClient, withFetch } from '@angular/common/http';
import { FormModule } from './form/form.module';
import { StudentsCrudModule } from './students-crud/students-crud.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    WebpageModule,
    DataBindingModule,
    AuthModule,
    RouterLink,
    FormModule,
    StudentsCrudModule
],
  providers: [
    provideClientHydration(),
    provideHttpClient(withFetch())
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
