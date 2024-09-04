import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { GpImgComponent } from "./gp-img/gp-img.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, GpImgComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'img-prog';
}
