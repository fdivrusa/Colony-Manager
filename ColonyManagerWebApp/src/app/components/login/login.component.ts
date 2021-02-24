import { Component, OnInit } from '@angular/core';
import { AuthenticationRequest } from 'src/app/models/Account/authenticationRequest';
import { AccountService } from 'src/app/services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
  authenticationRequest = new AuthenticationRequest();

  constructor(private accountService: AccountService) {}

  ngOnInit(): void {
    this.accountService
      .authenticate(this.authenticationRequest)
      .subscribe((req) => {
        console.log(req);
      });
  }
}
