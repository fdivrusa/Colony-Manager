import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { HttpErrorResponse } from '@angular/common/http';
import { Notification } from 'src/app/models/Application/documents';

@Injectable()
export class LoaderService {
  isLoading = new Subject<boolean>();
  error = new Subject<HttpErrorResponse>();
  notification = new Subject<Notification>();

  show() {
    this.isLoading.next(true);
  }

  hide() {
    this.isLoading.next(false);
  }
}
