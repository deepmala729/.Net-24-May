import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserData } from '../Models/UserData';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registerUserData: UserData = new UserData();
  constructor(private _auth: AuthService,private _router:Router) { }

  ngOnInit(): void {
  }

  registerUser() {
    this._auth.registerUser(this.registerUserData).subscribe((res: { token: string; }) => {
      localStorage.setItem('token',res.token);
      this._router.navigate(['/account'])
    },
      (      err: any) => console.log(err));
  }
  

}