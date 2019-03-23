import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Expense } from 'src/app/core/models/expense.model';
import { ExpensesHeader } from './../models/enums/ExpensesHeader';

@Injectable({
  providedIn: 'root'
})
export class ExpenseService {
  expensesHeader = [ ExpensesHeader.Date, ExpensesHeader.Food, ExpensesHeader.PinMoney, ExpensesHeader.Transport, ExpensesHeader.Bills, ExpensesHeader.Others ];

  public formData: Expense;
  public expensesList: Expense[];
  private readonly _url = 'https://localhost:5001/api/Expenses';

  constructor(private http: HttpClient) { }

  postExpense(expense: Expense) {
    return this.http.post(this._url, expense);
  }
}
