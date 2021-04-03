import { Component, OnInit } from '@angular/core';
import { User } from './models/Account/User';
import { TokenStorageService } from './services/token-storage.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  title = 'Colony Manager';
  loggedUser!: User;

  constructor(private tokenStorageService: TokenStorageService) {}

  ngOnInit(): void {
    this.loggedUser = this.tokenStorageService.getUser();
  }
}
