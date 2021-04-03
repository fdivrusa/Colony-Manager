import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/services/account.service';
import { TokenStorageService } from 'src/app/services/token-storage.service';
import { AuthenticationRequest } from './../../models/Account/authenticationRequest';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
  authenticationRequest = new AuthenticationRequest();
  isLoggedIn = false;
  isLoginFailed = false;
  errorMessage = '';

  constructor(
    private accountService: AccountService,
    private tokenStorageService: TokenStorageService
  ) {}

  ngOnInit(): void {
    if (this.tokenStorageService.getToken()) {
      this.isLoggedIn = true;
    }
  }

  onSubmit(): void {
    this.accountService.authenticate(this.authenticationRequest).subscribe(
      (data) => {
        this.tokenStorageService.saveToken(data.jwtToken);
        this.tokenStorageService.saveUser(data);

        this.isLoginFailed = false;
        this.isLoggedIn = true;

        this.reloadPage();
      },
      (err) => {
        this.errorMessage = err.error.ErrorMessage;
        this.isLoginFailed = true;
      }
    );
  }

  reloadPage(): void {
    window.location.reload();
  }
}
