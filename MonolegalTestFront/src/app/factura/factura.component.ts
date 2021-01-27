import { Component, OnInit } from '@angular/core';
import { Observable } from "rxjs";  
import { Router } from '@angular/router';  
import { Factura } from '../Shared/factura.model';
import { FacturaService } from '../Shared/factura.service';
@Component({
  selector: 'app-factura',
  templateUrl: './factura.component.html',
  styleUrls: ['./factura.component.css']
})
export class FacturaComponent implements OnInit {  

  constructor(public service:FacturaService) { }  
  
  ngOnInit():void {   
    this.service.refreshList();   
  }    
}  