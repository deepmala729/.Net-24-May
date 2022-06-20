import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Admin } from './admin.model';

@Component({
  templateUrl: './admin.component.html'
})
export class AdminComponent {

  constructor(public httpc:HttpClient) {
   

  }
  title = 'ECommerceApp';
  myname = 'Deepmala Gupta'
  AdminModel: Admin = new Admin();
  AdminModels: Array<Admin> = new Array<Admin>();
  AddAdmin() {
    console.log(this.AdminModel);
    //this.CustmerModels.push(this.CustomerModel);

    var admindto={
      adminId:this.AdminModel.adminId,
      adminName:this.AdminModel.adminName,
      
    }
    this.httpc.post("https://localhost:44315/api/Admin",admindto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.AdminModel = new Admin();
  }
  PostSuccess(res:any){
    console.log(res);
    
  }
  PostError(res:any){
    console.log(res);
  }
  EditAdmin(input: Admin) {
    this.AdminModel = input;
  }
  DeleteAdmin(input: Admin) {
    var index=this.AdminModels.indexOf(input);
    this.AdminModels.splice(index,1);
  }
  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44315/api/Admin").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.AdminModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}
