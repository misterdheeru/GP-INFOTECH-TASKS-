import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-data-binding-examples',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './data-binding-examples.component.html',
  styleUrl: './data-binding-examples.component.css'
})
export class DataBindingExamplesComponent {

  
 
path_1:string = "https://rukminim2.flixcart.com/image/312/312/xif0q/dslr-camera/i/o/c/eos-r100-24-1-eos-r100-kit-canon-original-imagqeydhsxgacxp.jpeg?q=70" ; 
 
IsActiveClass = true;

IsActivateCard =true

width="100%";

mobilenumber:any ="";

mystyles = {
  textaline:"center",
  bgcolor:"red",
  width:"100%",
  margin:"10px"
}

username:string ="";


blackANDwhite()
{
   this.IsActivateCard=!this.IsActivateCard;
}
change(event:any)
{
   this.mobilenumber =event.target.value;
}


}
