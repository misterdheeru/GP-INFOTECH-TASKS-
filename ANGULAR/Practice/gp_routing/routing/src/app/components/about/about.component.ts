import { Component } from '@angular/core';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-about',
  standalone: true,
  imports: [],
  templateUrl: './about.component.html',
  styleUrl: './about.component.css'
})
export class AboutComponent {

     router:any 
  constructor(private route :Router)
  {
     
     this.router =route
  }

  Redirect()
  {
    this.router.navigate([ '/contacts' ]);
  }
}
