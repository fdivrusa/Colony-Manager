import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from './models/Account/User';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  title = 'Colony Manager';
  loggedUser!: User;

  ngOnInit(): void {

  }
}
