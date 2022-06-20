import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { User } from './user.model';

@Component({
  templateUrl: './user.component.html'
})
export class UserComponent {

  constructor(public httpc:HttpClient) {
   

  }
  title = 'ECommerceApp';
  myname = 'Deepmala Gupta'
  UserModel: User = new User();
  UserrModels: Array<User> = new Array<User>();
  AddUser() {
    console.log(this.UserModel);
    //this.CustomerModels.push(this.CustomerModel);

    var userdto={
      userId:this.UserModel.userId,
      userName:this.UserModel.userName,
    }
    this.httpc.post("https://localhost:44315/api/User",userdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.UserModel = new User();
  }
  PostSuccess(res:any){
    console.log(res);
    
  }
  PostError(res:any){
    console.log(res);
  }
  EditUser(input: User) {
    this.UserModels = input;
  }
  DeleteUser(input: User) {
    var index=this.UserModels.indexOf(input);
    this.UserModels.splice(index,1);
  }
  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44315/api/User").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.UserModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}
