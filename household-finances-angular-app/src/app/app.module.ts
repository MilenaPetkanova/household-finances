import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
// import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';
import { CapitalsComponent } from './capitals/capitals.component';
import { CapitalComponent } from './capitals/capital/capital.component';
import { CapitalListComponent } from './capitals/capital-list/capital-list.component';

import { CapitalService } from './shared/capital.service';

@NgModule({
  declarations: [
    AppComponent,
    CapitalsComponent,
    CapitalComponent,
    CapitalListComponent
  ],
  imports: [
    BrowserModule,
    // ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    CommonModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [CapitalService],
  bootstrap: [AppComponent]
})
export class AppModule { }
