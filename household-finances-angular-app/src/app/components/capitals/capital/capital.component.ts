import { Component, OnInit } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { NgbModal, NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { CapitalService } from './../../../core/services/capital.service';
import { Capital } from '../../../core/models/capital.model';
import { CapitalsHeader } from './../../../core/models/enums/CapitalsHeader';

@Component({
  selector: 'app-capital',
  templateUrl: './capital.component.html',
  styleUrls: ['./capital.component.css']
})
export class CapitalComponent implements OnInit {
  capital: Capital;
  capitalsHeader: CapitalsHeader[] = this._capitalService.capitalsHeader;

  constructor(private _capitalService: CapitalService, private _toastr: ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(capitalForm?: NgForm) {
    this._capitalService.formData = new Capital();
    this.capital = this._capitalService.formData;
  }

  onSubmit(capitalForm?: NgForm) {
    this.insertRecord(capitalForm);
  }

  insertRecord(capitalForm) {
    this._capitalService.formData = capitalForm.value;

    const currentDate = capitalForm.value.dp.year.toString() + '-' +
     capitalForm.value.dp.month.toString() + '-' + capitalForm.value.dp.day.toString();

    this._capitalService.formData.createdOn = currentDate;

    this.capital = this._capitalService.formData;

    this._capitalService.postCapital(this.capital).subscribe(res => {
      this._toastr.success('Record added successfully.', 'Capital register');
      this.resetForm(capitalForm);
    });
  }
}
