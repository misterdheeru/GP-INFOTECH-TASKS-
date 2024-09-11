import { Component, ViewChild } from '@angular/core';
import { ComponentCommunication1Component } from "../component-communication-1/component-communication-1.component";

@Component({
  selector: 'gp-component-communication-parrent',
  standalone: true,
  imports: [ComponentCommunication1Component],
  templateUrl: './component-communication-parrent.component.html',
  styleUrl: './component-communication-parrent.component.css'
})
export class ComponentCommunicationParrentComponent {

  @ViewChild("txtname") NAME:any

  name:string |undefined;

  senddata()
  {
   this.name = this.NAME.nativeElement.value;
  }
 
  
}
