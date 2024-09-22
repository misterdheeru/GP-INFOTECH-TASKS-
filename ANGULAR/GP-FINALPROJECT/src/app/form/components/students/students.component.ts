import {ChangeDetectionStrategy, Component } from '@angular/core';
import {inject, TemplateRef } from '@angular/core';
import { NgbOffcanvas } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrl: './students.component.css',
   changeDetection: ChangeDetectionStrategy.OnPush,
})
export class StudentsComponent {

  private offcanvasService = inject(NgbOffcanvas);


    updateShow = true;
	openBottom(content: TemplateRef<any>) {
		this.offcanvasService.open(content, { position: 'bottom' ,panelClass: 'custom-offcanvas'});
	}
 
	close() {
		this.offcanvasService.dismiss();  
		console.log("CLOSED");
	  }
 
}
 