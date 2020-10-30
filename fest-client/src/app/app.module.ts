import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';

import { FestNavbarComponent } from './components/fest-navbar/fest-navbar.component';
import { FestInputComponent } from './components/fest-input/fest-input.component';

import { MaterialModule } from './material/material.module'
import { FormsModule } from '@angular/forms';
import { FestContentComponent } from './components/fest-content/fest-content.component';
import { FestContentItemComponent } from './components/fest-content-item/fest-content-item.component'

@NgModule({
  declarations: [
    AppComponent,
    FestNavbarComponent,
    FestInputComponent,
    FestContentComponent,
    FestContentItemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MaterialModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
