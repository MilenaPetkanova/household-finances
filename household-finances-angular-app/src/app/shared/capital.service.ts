import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Capital } from './capital.model';

@Injectable({
  providedIn: 'root'
})
export class CapitalService {

  formData: Capital;
  readonly rootUrl = 'https://localhost:5001/api';

  constructor(private _http: HttpClient) { }

  postCapital(formData: Capital) {
    return this._http.post(this.rootUrl + '/Capitals', formData);
  }
}
