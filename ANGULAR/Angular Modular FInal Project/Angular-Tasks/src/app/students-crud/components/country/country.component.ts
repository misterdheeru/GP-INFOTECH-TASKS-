import { Component } from '@angular/core';
import { CountryService } from '../../services/country.service';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-country',
  templateUrl: './country.component.html',
  styleUrls: ['./country.component.css']
})
export class CountryComponent {

  CountryForm:any;
  selectedFile: File | null = null;

  constructor(private formbulder: FormBuilder, private servicecountry: CountryService) {
    this.CountryForm = this.formbulder.group({
      COUNTRY_ID: this.formbulder.control(""),
      COUNTRY_CODE: this.formbulder.control(""),
      COUNTRY_NAME: this.formbulder.control("")
    });
  }

  // This function is triggered when a file is selected
  onFileSelected(event: any) {
    this.selectedFile = event.target.files[0];
  }

  submitdetails(DATA: any) {
    const formData = new FormData();

    // Append form values
    formData.append('COUNTRY_ID', DATA.value.COUNTRY_ID);
    formData.append('COUNTRY_CODE', DATA.value.COUNTRY_CODE);
    formData.append('COUNTRY_NAME', DATA.value.COUNTRY_NAME);

    // Append the file if selected
    if (this.selectedFile) {
      formData.append('COUNTRY_IMG_PATH', this.selectedFile, this.selectedFile.name);
    }

    // Call service to submit form data
    this.servicecountry.insert(formData).subscribe(() => {
      console.log("Form submitted successfully.");
    }, error => {
      console.error("Error occurred while submitting form.", error);
    });
  }
}
