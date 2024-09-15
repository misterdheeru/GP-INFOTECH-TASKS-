import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {
 
  username:any 
  ngOnInit(): void {
    this.username =  sessionStorage.getItem('username')?.toString();  
  }
  
}
