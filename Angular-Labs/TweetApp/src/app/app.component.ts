import { Component } from '@angular/core';
import { AuthService } from './services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TweetWebApp';
  public totalItem : number = 0;
  constructor(private _auth:AuthService){ }

  ngOnInit(): void {
    
  }
  
  LoggedIn(input:boolean){
    if(input){
      return this._auth.loggedIn();
    }
    else{
      return !this._auth.loggedIn();
    }
  }
  LogOut(){
    this._auth.logoutUser();
  }
}