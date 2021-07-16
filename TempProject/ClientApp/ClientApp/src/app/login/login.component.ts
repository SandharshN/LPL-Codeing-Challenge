import { Component } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})
export class LoginComponent {
  Username: string;
  Password: string;
  showError: boolean = false;

  constructor(private router: Router) {
   
  }

  login(): void {
    if (this.Username && this.Password) {
      var user = localStorage.getItem("Username");
      var password = localStorage.getItem("Password");
      if (!user && !password) {
        localStorage.setItem("Username", this.Username);
        localStorage.setItem("Password", this.Password);
      }
      if (user == this.Username && password == this.Password) {
        this.router.navigate('../product-list');
      }
      else {
        this.showError = true;
      }
    }
    
  }
}
