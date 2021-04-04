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

  constructor() {}

  ngOnInit(): void {}
}
