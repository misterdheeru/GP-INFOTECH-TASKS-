import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CountryService {

  url = "https://localhost:44319/api/Countrys/AddFile";

  constructor(private httpclient: HttpClient) { }

  insert(formData: FormData) {
    return this.httpclient.post(this.url, formData);
  }
}
