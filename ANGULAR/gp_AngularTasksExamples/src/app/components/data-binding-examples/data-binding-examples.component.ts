import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-data-binding-examples',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './data-binding-examples.component.html',
  styleUrl: './data-binding-examples.component.css'
})
export class DataBindingExamplesComponent {

  parth1:string = "https://rukminim2.flixcart.com/image/312/312/xif0q/dslr-camera/i/o/c/eos-r100-24-1-eos-r100-kit-canon-original-imagqeydhsxgacxp.jpeg?q=70" ; 
  parth2:string ="https://rukminim2.flixcart.com/image/612/612/xif0q/smartwatch/t/c/c/42-9-wave-call-android-ios-boat-yes-original-imagz5hnkpfdagzv.jpeg?q=70"
  parth3:string ="https://images.picxy.com/cache/2019/9/16/22c2945eb8c31ded43ed32efd9e4b98f.jpg";
  parth4:string="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7NRRx19AUrKi_N5GSPl7v4RTcM7ykQa1cig&s";



  IsActiveClass = true;
  IsActiveTwo=true;


  fontstyles = {

    fontweight: "bold"
  }
}
