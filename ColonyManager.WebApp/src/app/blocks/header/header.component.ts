import { Component, OnInit, ViewChild } from '@angular/core';
import { MatSidenav } from '@angular/material/sidenav';
import { faPowerOff, faTools } from '@fortawesome/free-solid-svg-icons';
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
  faLogout = faPowerOff;
  faParam = faTools;

  constructor(
    private store: Store<IStoreState>,
    private tokenStorageService: TokenStorageService
  ) {}

  @ViewChild('sidenav') sidenav!: MatSidenav;

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

  toggle() {
    this.sidenav.toggle();
  }
}
