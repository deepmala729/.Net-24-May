import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccountComponent } from './account/account.component';
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { CartComponent } from './cart/cart.component';
import { AdminComponent } from './admin/admin.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { OrderconfirmedComponent } from './orderconfirmed/orderconfirmed.component';
import { UserDetailsComponent } from './user-details/user-details.component';
import { CategoryComponent } from './category/category.component';



const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'register',
    component: RegisterComponent
  },
  {
    path: 'account',
    component: AccountComponent
  },
  {
    path: 'dashboard',
    component: DashboardComponent
  },
  {
    path: 'cart',
    component: CartComponent
  },
  
  {
    path: 'checkout',
    component: CheckoutComponent
  },
  
  {
    path:'admin',
    component:AdminComponent
  },
  {
    path: 'orderconfirmed',
    component: OrderconfirmedComponent
  },
  
  {
    path:'userdetails',
    component:UserDetailsComponent
  },
  {
    path: 'category',
    component: CategoryComponent
  },
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
