import { Component } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
 
  ShowHeaderAndFooter =true;
  constructor(private rooting :Router)
  {
    
      rooting.events.subscribe(routevalues=>{
        if(routevalues instanceof NavigationEnd)
        {
          if(
            routevalues.url=="/" 
 
          )
          {
           this.ShowHeaderAndFooter =true;
          }
         else if(
            routevalues.url=="" 
 

          )
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
