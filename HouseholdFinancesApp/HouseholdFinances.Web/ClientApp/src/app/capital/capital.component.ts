import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-capital',
  templateUrl: './capital.component.html'
})
export class CapitalComponent {
  public capitals: Capital[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Capital[]>(baseUrl + 'api/Capital/All').subscribe(result => {
      this.capitals = result;
    }, error => console.error(error));
  }
}

interface Capital {
  cash: number;
  debitCardFirst: number;
  debitCardSecond: number;
  debitCardThird: number;
}
