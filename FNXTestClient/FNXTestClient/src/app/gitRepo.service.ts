import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';


const httpOptions = {
    headers: new HttpHeaders({ 
      'Access-Control-Allow-Origin':'*',
      'Access-Control-Allow-Method':'*',
    })
  };

@Injectable({
  providedIn: 'root'
})
export class GitRepoService {
  constructor(private httpClient: HttpClient) { }

  public searchRepo(value:any){
    return this.httpClient.get("https://localhost:7166/api/git/repos?query=" + value, httpOptions);
  }
}