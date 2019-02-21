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

  public service;
  public reactiveForm: FormGroup;

  constructor(private _formBuilder: FormBuilder, private _capitalService: CapitalService, private _toastr: ToastrService) { }

  ngOnInit() {
    this.service = this._capitalService;
    this.reactiveForm = this._formBuilder.group({
      cash: [null, Validators.required],
      debitCardFirst: [null, Validators.required],
      debitCardSecond: [null, Validators.required],
      debitCardThird: [null, Validators.required]
    });
  }

  get cash() { return this.reactiveForm.get('cash'); }
  get debitCardFirst() { return this.reactiveForm.get('debitCardFirst'); }
  get debitCardSecond() { return this.reactiveForm.get('debitCardSecond'); }
  get debitCardThird() { return this.reactiveForm.get('debitCardThird'); }

  onSubmit() {
    this._capitalService.postCapital(this.reactiveForm.value).subscribe(res => {
      this._toastr.success('Record added successfully.', 'Capital register');
      this.reactiveForm.reset();
    });
  }
}

