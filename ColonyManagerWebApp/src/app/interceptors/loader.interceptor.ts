import {
  HttpInterceptor,
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpErrorResponse,
  HttpResponse,
  HTTP_INTERCEPTORS,
} from '@angular/common/http';
import { Injectable } from '@angular/core';
// tslint:disable-next-line: import-blacklist
import { Observable, throwError } from 'rxjs';
import { finalize, map, catchError } from 'rxjs/operators';
import { LoaderService } from '../services/loader.service';
import { AuthInterceptor } from './auth.interceptor';

@Injectable()
export class LoaderInterceptor implements HttpInterceptor {
  counter = 0;
  constructor(private loaderService: LoaderService) {}

  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    this.counter++;
    this.loaderService.show();
    return next.handle(req).pipe(
      map((event: HttpEvent<any>) => {
        return event;
      }),
      finalize(() => {
        this.counter--;
        if (this.counter === 0) {
          this.loaderService.hide();
        }
      })
    );
  }
}

export const loaderInterceptorProviders = [
  { provide: HTTP_INTERCEPTORS, useClass: LoaderInterceptor, multi: true },
];
