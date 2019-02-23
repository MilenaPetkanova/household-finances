import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

import { CapitalService } from 'src/app/shared/capital.service';
import { Capital } from './../../shared/capital.model';

@Component({
  selector: 'app-capital-list',
  templateUrl: './capital-list.component.html',
  styleUrls: ['./capital-list.component.css']
})
export class CapitalListComponent implements OnInit {

  capitals: Capital[];

  constructor(private _capitalService: CapitalService, private _toastr: ToastrService) {
  }

  ngOnInit() {
    this._capitalService.refreshList()
      .subscribe(data => {
          this._capitalService.capitalsList = data;
          this.capitals = this._capitalService.capitalsList;
        }, err => {
          console.log(err);
        });
  }

  populateForm(capital: Capital) {
    this._capitalService.formData = capital;
  }

  onDelete(id: number) {
  if(confirm('Are you sure you want to delete this record?')) {
    this._capitalService.deleteCapital(id)
      .subscribe(res => {
        this._toastr.warning('Succesfully deleted.', 'Capital delete');
        this._capitalService.refreshList();
      }, err => {
        console.log(err);
      });
  }

    // this._capitalService.deleteCapital(id)
    //   .subscribe(res => {
    //     console.log('ondelete' + res);
    //     this._capitalService.refreshList();
    //     this._toastr.warning('Deleted seccessfully.');
    //   }, err => {
    //     console.log(err);
    //   });

      // this._capitalService.refreshList()
      // .subscribe(data => {
      //   this.capitals = data;
      // }, err => {
      //   console.log(err);
      // });
  }
}
