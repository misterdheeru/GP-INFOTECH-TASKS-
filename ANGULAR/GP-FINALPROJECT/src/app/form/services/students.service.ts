import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentsService {

  options = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };

  Countrys = "http://localhost:50551/api/Country";

  States = "http://localhost:50551/api/States";

  City = "http://localhost:50551/api/City";

  constructor(private httpclient:HttpClient) 
  {


  }

  AllCountry()
  {
   return this.httpclient.get(this.Countrys,this.options);
  }
  AllStates()
  {
   return this.httpclient.get(this.States,this.options);
  }
  AllCity()
  {
   return this.httpclient.get(this.City,this.options);
  }
  

}
