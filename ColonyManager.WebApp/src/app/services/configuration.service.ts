import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ConfigurationGroup } from './../models/configurations/configurationGroup';

const apiUrl = environment.apiUrl;
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
};

@Injectable({
  providedIn: 'root',
})
export class ConfigurationService {
  constructor(private httpClient: HttpClient) {}

  getConfigurationGroups(): Observable<ConfigurationGroup[]> {
    return this.httpClient.get<ConfigurationGroup[]>(
      apiUrl + 'configGenericGroups'
    );
  }
}
