import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FacturaComponent } from './factura/factura.component';
import {NgxPaginationModule} from 'ngx-pagination';  
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FacturaService } from './Shared/factura.service';


@NgModule({
  declarations: [
    AppComponent,
    FacturaComponent,
  ],
  imports: [
    BrowserModule,FormsModule,HttpClientModule,ReactiveFormsModule,NgxPaginationModule
  ],
  providers: [FacturaService],
  bootstrap: [AppComponent]
})
export class AppModule { }

 
