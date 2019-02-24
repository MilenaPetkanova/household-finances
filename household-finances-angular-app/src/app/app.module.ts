import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { NgbDate, NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import { CapitalsComponent } from './components/capitals/capitals.component';
import { CapitalComponent } from './components/capitals/capital/capital.component';
import { CapitalListComponent } from './components/capitals/capital-list/capital-list.component';

import { CapitalService } from './core/services/capital.service';
import { AppRoutingModule } from './app-routing.module';
import { NavComponent } from './components/shared/nav/nav.component';

@NgModule({
  declarations: [
    AppComponent,
    CapitalsComponent,
    CapitalComponent,
    CapitalListComponent,
    NavComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    CommonModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    NgbModule.forRoot(),
    AppRoutingModule,
  ],
  providers: [CapitalService],
  bootstrap: [AppComponent]
})
export class AppModule { }
