import { Component, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { User } from 'src/app/models/Account/User';
import { TokenStorageService } from 'src/app/services/token-storage.service';
import { SetLoggedUser } from 'src/app/store/actions/app.actions';
import { loggedUserSelector } from 'src/app/store/selectors/app.selector';
import { IStoreState } from 'src/app/store/state/store.state';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {
  loggedUser$!: Observable<User>;

  constructor(
    private store: Store<IStoreState>,
    private tokenStorageService: TokenStorageService
  ) {}

  ngOnInit(): void {
    this.loggedUser$ = this.store.select(loggedUserSelector);
  }

  logout() {
    this.tokenStorageService.signout();
    this.store.dispatch(
      SetLoggedUser({
        payload: new User(),
      })
    );
  }
}
