import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { CapitalService } from './../../shared/capital.service';
import { NgForm } from '@angular/forms';
import {FormControl, FormGroup, FormBuilder, Validators} from '@angular/forms';

@Component({
  selector: 'app-capital',
  templateUrl: './capital.component.html',
  styleUrls: ['./capital.component.css']
})
export class CapitalComponent implements OnInit {

  public service;
  public reactiveForm: FormGroup;

  constructor(private _formBuilder: FormBuilder, private _capitalService: CapitalService) { }

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

  // onSubmit(form: NgForm) {
  //   this.insertRecord(form);
  // }

  insertRecord(form: NgForm) {
    this._capitalService.postCapital(form.value).subscribe(res => {
      console.log(res);
    });
  }

  onSubmit() {
    console.log(this.reactiveForm.value);

  }
}

