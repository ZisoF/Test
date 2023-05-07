import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { LoginModel } from './interfaces/login.model'


const httpOptions = {
    headers: new HttpHeaders({ 
      'Access-Control-Allow-Origin':'*',
      'Access-Control-Allow-Method':'*',
    })
  };

@Injectable({
  providedIn: 'root'
})
export class LoginService {
    
  credentials: LoginModel = {username:'johndoe', password:'def@123'};

  constructor(private httpClient: HttpClient) { }

  public login(){
    return this.httpClient.post("https://localhost:7166/api/auth/login", this.credentials , httpOptions);
  }
}