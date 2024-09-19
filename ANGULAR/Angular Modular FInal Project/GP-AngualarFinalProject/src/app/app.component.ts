import { Component } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  ShowHeaderAndFooter =true;
  constructor(private routing :Router)
  {
    routing.events.subscribe(routevalues=>{
      if(routevalues instanceof NavigationEnd)
      {
        console.log(routevalues.url);
        if(
          routevalues.url=="/app-login" ||
          routevalues.url=="/app-form-builder" ||
          routevalues.url=="/app-template-driven-forms" ||
          routevalues.url=="/app-reactive-forms" ||
          routevalues.url=="/app-home"||
          routevalues.url=="/")
        {
         this.ShowHeaderAndFooter =false;
        }
       else if(
          routevalues.url=="/app-country" ||
          routevalues.url=="/app-states" ||
          routevalues.url=="/app-students"||
          routevalues.url=="/app-city")
        {
          this.ShowHeaderAndFooter =true;
        }
        else
        {
          this.ShowHeaderAndFooter =true;
        }
      }
    })
  }
}
