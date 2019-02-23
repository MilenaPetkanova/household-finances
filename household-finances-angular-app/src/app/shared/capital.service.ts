import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Capital } from './capital.model';


@Injectable({
  providedIn: 'root'
})
export class CapitalService {

  public formData: Capital;
  public capitalsList: Capital[];
  private readonly _url = 'https://localhost:5001/api/Capitals';

  constructor(private http: HttpClient) { }

  refreshList(): Observable<Capital[]> {
    return this.http.get<Capital[]>(this._url);
  }

  postCapital(formData: Capital) {
    return this.http.post(this._url, formData);
  }

  deleteCapital(id: number) {
    return this.http.delete(this._url + '/' + id);
  }
}
