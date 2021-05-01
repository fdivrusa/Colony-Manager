import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { HttpErrorResponse } from '@angular/common/http';

@Injectable()
export class LoaderService {
  isLoading = new Subject<boolean>();
  error = new Subject<HttpErrorResponse>();

  show() {
    this.isLoading.next(true);
  }

  hide() {
    this.isLoading.next(false);
  }
}
