import { Component, OnInit } from '@angular/core';

import { CapitalService } from './../../shared/capital.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-capital',
  templateUrl: './capital.component.html',
  styleUrls: ['./capital.component.css']
})
export class CapitalComponent implements OnInit {

  public service;

  constructor(private _capitalService: CapitalService ) { }

  ngOnInit() {
    this.service = this._capitalService;
  }

  onSubmit(form: NgForm) {
    this.insertRecord(form);
  }

  insertRecord(form: NgForm) {
    this._capitalService.postCapital(form.value).subscribe(res => {
      console.log(res);
    });
  }
}
