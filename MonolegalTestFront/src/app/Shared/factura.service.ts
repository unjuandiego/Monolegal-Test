import { Injectable } from '@angular/core';  
import { Observable } from "rxjs";  
import {HttpHeaders, HttpClient } from "@angular/common/http";  
import { Factura } from './factura.model';
@Injectable({  
  providedIn: 'root'  
})  
export class FacturaService {  
   
  constructor(private http:HttpClient) { }  

  readonly BaseURL="http://localhost:44328/api/Factura";  
  formData: Factura = new Factura();
  list: Factura[];

  refreshList(){
    this.http.get(this.BaseURL+"/GetAllFactura").toPromise()
    .then(res => this.list = res as Factura[]);
    console.log(this.list);
  }
}  