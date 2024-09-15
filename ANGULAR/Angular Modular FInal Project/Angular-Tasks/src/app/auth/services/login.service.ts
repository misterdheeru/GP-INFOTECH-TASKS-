import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
 

@Injectable({
  providedIn: 'root'
})

 
export class LoginService {

 
 

  constructor( private httpclient:HttpClient)
  { 
   
  }
  
  userLogin(userLogin:any)
  {
   return this.httpclient.post("https://localhost:44319/api/Registration/Login",userLogin);
  }

  
}
