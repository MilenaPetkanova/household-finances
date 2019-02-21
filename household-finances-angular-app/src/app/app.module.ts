import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

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
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [CapitalService],
  bootstrap: [AppComponent]
})
export class AppModule { }
