import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/services/account.service';
import { TokenStorageService } from 'src/app/services/token-storage.service';
import { AuthenticationRequest } from './../../models/Account/authenticationRequest';
import { Observable } from 'rxjs';
import { User } from 'src/app/models/Account/User';
import { select, Store } from '@ngrx/store';
import { IStoreState } from 'src/app/store/state/store.state';
import { loggedUserSelector } from './../../store/selectors/user.selector';
import { SetLoggedUser } from 'src/app/store/actions/user.actions';

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
    private store: Store<IStoreState>,
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

        this.store.dispatch(
          SetLoggedUser({
            payload: {
              createdDate: data.createdDate,
              email: data.email,
              firstName: data.firstName,
              id: data.id,
              isVerified: data.isVerified,
              jwtToken: data.jwtToken,
              lastName: data.lastName,
              role: data.lastName,
              title: data.title,
              updatedDate: data.updatedDate,
            },
          })
        );

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
