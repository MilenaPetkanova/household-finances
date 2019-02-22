import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

import { CapitalService } from './../../shared/capital.service';

@Component({
  selector: 'app-capital',
  templateUrl: './capital.component.html',
  styleUrls: ['./capital.component.css']
})
export class CapitalComponent implements OnInit {

  capitalForm: FormGroup;

  constructor(private _formBuilder: FormBuilder, private _capitalService: CapitalService, private _toastr: ToastrService) { }

  ngOnInit() {
    this.capitalForm = this._formBuilder.group({
      cash: [null, Validators.required],
      debitCardFirst: [null, Validators.required],
      debitCardSecond: [null, Validators.required],
      debitCardThird: [null, Validators.required]
    });
  }

  get cash() { return this.capitalForm.get('cash'); }
  get debitCardFirst() { return this.capitalForm.get('debitCardFirst'); }
  get debitCardSecond() { return this.capitalForm.get('debitCardSecond'); }
  get debitCardThird() { return this.capitalForm.get('debitCardThird'); }

  onSubmit() {
    this._capitalService.postCapital(this.capitalForm.value).subscribe(res => {
      this._toastr.success('Record added successfully.', 'Capital register');
      this.capitalForm.reset();
    });
  }
}
