import { Component, OnInit } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

import { ExpenseService } from 'src/app/core/services/expense.service';
import { Expense } from 'src/app/core/models/expense.model';
import { ExpensesHeader } from 'src/app/core/models/enums/ExpensesHeader';

@Component({
  selector: 'app-expense',
  templateUrl: './expense.component.html',
  styleUrls: ['./expense.component.css']
})
export class ExpenseComponent implements OnInit {
  expense: Expense;
  expensesHeader: ExpensesHeader[] = this._expenseService.expensesHeader;

  constructor(private _expenseService: ExpenseService, private _toastr: ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(expenseForm?: NgForm) {
    this._expenseService.formData = new Expense();
    this.expense = this._expenseService.formData;
  }

  onSubmit(expenseForm?: NgForm) {
    this.insertRecord(expenseForm);
  }

  insertRecord(expenseForm) {
    this._expenseService.formData = expenseForm.value;

    const date = expenseForm.value.dp.year.toString() + '-' +
      expenseForm.value.dp.month.toString() + '-' + expenseForm.value.dp.day.toString();

    this._expenseService.formData.date = date;

    this.expense = this._expenseService.formData;

    this._expenseService.postExpense(this.expense).subscribe(res => {
      this._toastr.success('Record added successfully.', 'Expense register');
      this.resetForm(expenseForm);
    });
  }
}
