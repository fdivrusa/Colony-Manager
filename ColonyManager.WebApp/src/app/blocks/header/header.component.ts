import { Component, OnInit, ViewChild } from '@angular/core';
import { MatSidenav } from '@angular/material/sidenav';
import { Router } from '@angular/router';
import { faPowerOff, faTools } from '@fortawesome/free-solid-svg-icons';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { User } from 'src/app/models/Account/User';
import { SideMenuItem } from 'src/app/models/menu/sideMenuItem';
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
  menuItems: SideMenuItem[] = [];
  faLogout = faPowerOff;
  faParam = faTools;

  constructor(
    private store: Store<IStoreState>,
    private tokenStorageService: TokenStorageService,
    private router: Router
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

  loadSideMenuItems(menuItem: string) {
    this.menuItems = [];
    switch (menuItem) {
      case 'PEOPLES':
        this.menuItems.push(new SideMenuItem('Peoples', '/peoples'));
        this.menuItems.push(
          new SideMenuItem('Attributions', '/peoples/attributions')
        );
        this.menuItems.push(new SideMenuItem('Contacts', '/peoples/contacts'));
        this.menuItems.push(
          new SideMenuItem('Addresses', '/peoples/addresses')
        );

        if (this.sidenav && !this.sidenav.opened && this.menuItems.length > 0) {
          this.sidenav.toggle();
        }

        break;

      default:
        if (this.sidenav && this.sidenav.opened) {
          this.sidenav.toggle();
        }
        break;
    }
  }

  navigateToRoute(route: string) {
    if (this.sidenav && this.sidenav.opened) {
      this.sidenav.toggle();
    }
    this.router.navigate([route]);
  }
}
