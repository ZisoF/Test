import { Component, OnInit  } from '@angular/core';

import {MatSnackBar} from '@angular/material/snack-bar';

import { LoginService } from './login.service'
import { GitRepoService } from './gitRepo.service'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  title = 'FNXTestClient';
  searchValue:any = '';
  isLoading:boolean = false;
  invalidLogin:boolean = true;

  respos:any = undefined;

  constructor(private loginService: LoginService, private gitService: GitRepoService, private _snackBar: MatSnackBar) { }

  ngOnInit(): void { 

    this.loginService.login().subscribe({
      next: (response: any) => {
        const token = response.token;
        localStorage.setItem("jwt", token); 
        this.invalidLogin = false; 
        this._snackBar.open("Authenticated", 'Success');
      },
      error: (err: any) => { this.invalidLogin = true;  this._snackBar.open("UnAuthenticated", 'Error'); }
    })

  }

  onSubmit(event:any){
    this.isLoading = true;
    event.preventDefault()

    this.gitService.searchRepo(this.searchValue).subscribe(
    data => {  
      this.isLoading = false;
      this.respos = data;
    },
    error=>{
      this.isLoading = false;
      this._snackBar.open(error.error, 'Error');
      console.log(error)
    })
  }

  bookMark(item:any){
    if(!sessionStorage.getItem(item.id)){
        sessionStorage.setItem(item.id, JSON.stringify(item));
        this._snackBar.open('bookmarked item: ' + item.name, 'Info');
    }
    else{
      this._snackBar.open('item: ' + item.name + ' allready bookmarked!', 'Info');
    }
  }
}
