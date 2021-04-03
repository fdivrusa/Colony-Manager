import { Component, OnInit } from '@angular/core';
import { select, Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { User } from 'src/app/models/Account/User';
import { IStoreState } from 'src/app/store/state/store.state';
import { loggedUserSelector } from './../../store/selectors/user.selector';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {
  loggedUser: User | undefined;
  loggedUser$ = this.store.pipe(
    select(loggedUserSelector),
    tap((loggedUser) => {
      console.log(loggedUser);
      this.loggedUser = loggedUser;
    })
  );

  constructor(private store: Store<IStoreState>) {}

  ngOnInit(): void {}
}
