import { Component, Input } from '@angular/core';

@Component({
  selector: 'gp-component-communication-1',
  standalone: true,
  imports: [],
  templateUrl: './component-communication-1.component.html',
  styleUrl: './component-communication-1.component.css'
})
export class ComponentCommunication1Component {
 
  @Input() childtitle:string | undefined
 
}
