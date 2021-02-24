import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { AuthenticationRequest } from './../models/Account/authenticationRequest';
import { RevokeTokenRequest } from './../models/Account/revokeTokenRequest';
import { RegistrationRequest } from './../models/Account/registrationRequest';

const apiUrl = environment.apiUrl + 'accounts/';
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
};

@Injectable({
  providedIn: 'root',
})
export class AccountService {
  constructor(private httpClient: HttpClient) {}

  authenticate(request: AuthenticationRequest): Observable<any> {
    return this.httpClient.post(apiUrl + 'authenticate', request, httpOptions);
  }

  refreshToken(): Observable<any> {
    return this.httpClient.post(apiUrl + '/refresh-token', null, httpOptions);
  }

  revokeToken(request: RevokeTokenRequest): Observable<any> {
    return this.httpClient.post(apiUrl + '/revoke-token', request, httpOptions);
  }

  register(request: RegistrationRequest): Observable<any> {
    return this.httpClient.post(apiUrl + '/register', request, httpOptions);
  }
}
