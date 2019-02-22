import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';

import { Capital } from './capital.model';

@Injectable({
  providedIn: 'root'
})
export class CapitalService {

  formData: Capital;
  capitalForm: FormGroup;
  capitalsList: Capital[];
  private readonly _url = 'https://localhost:5001/api/Capitals';

  constructor(private http: HttpClient) { }

  postCapital(formData: Capital) {
    return this.http.post(this._url, formData);
  }

  refreshList(): Observable<Capital[]> {
    console.log('refresh');

    return this.http.get<Capital[]>(this._url);
  }

  deleteCapital(id: number) {
    return this.http.delete(this._url + '/' + id);
  }
}
