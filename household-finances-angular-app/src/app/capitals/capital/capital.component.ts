import { Component, OnInit } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

import { CapitalService } from './../../shared/capital.service';
import { Capital } from './../../shared/capital.model';

@Component({
  selector: 'app-capital',
  templateUrl: './capital.component.html',
  styleUrls: ['./capital.component.css']
})
export class CapitalComponent implements OnInit {

  public capital: Capital;

  constructor(private _capitalService: CapitalService, private _toastr: ToastrService) { }

  ngOnInit() {
    this.capital = new Capital();
  }

  resetForm() {
  }

  onSubmit(capitalForm?: NgForm) {
    this.capital = capitalForm.value;
    this._capitalService.postCapital(this.capital).subscribe(res => {
      this._toastr.success('Record added successfully.', 'Capital register');
    });
  }
}
