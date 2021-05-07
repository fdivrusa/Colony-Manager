import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/services/account.service';
import { TokenStorageService } from 'src/app/services/token-storage.service';
import { AuthenticationRequest } from '../../models/Account/authenticationRequest';
import { Store } from '@ngrx/store';
import { IStoreState } from 'src/app/store/state/store.state';
import { SetLoggedUser } from 'src/app/store/actions/app.actions';
import { Observable } from 'rxjs';
import { User } from 'src/app/models/Account/User';
import { loggedUserSelector } from 'src/app/store/selectors/app.selector';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
  authenticationRequest = new AuthenticationRequest();
  isLoginFailed = false;
  errorMessage = '';
  loggedUser$!: Observable<User>;

  constructor(
    private store: Store<IStoreState>,
    private accountService: AccountService,
    private tokenStorageService: TokenStorageService
  ) {}

  ngOnInit(): void {
    this.loggedUser$ = this.store.select(loggedUserSelector);
    if (this.tokenStorageService.getToken()) {
      this.store.dispatch(
        SetLoggedUser({
          payload: this.tokenStorageService.getUser(),
        })
      );
    }
  }

  onSubmit(): void {
    this.accountService.authenticate(this.authenticationRequest).subscribe(
      (data) => {
        this.tokenStorageService.saveToken(data.jwtToken);
        this.tokenStorageService.saveUser(data);

        this.isLoginFailed = false;

        if (data) {
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
                role: data.role,
                title: data.title,
                updatedDate: data.updatedDate,
              },
            })
          );
        }
      },
      (err) => {
        this.errorMessage = err.error.ErrorMessage;
        this.isLoginFailed = true;
      }
    );
  }
}
