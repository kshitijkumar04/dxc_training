import { Component, OnInit } from '@angular/core';
import {Company} from '../company';
import{CompanyService} from '../company.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {

  com= new Company();
  constructor(private comp:CompanyService, private route:Router) { }
    
  ngOnInit() {
  }
  addcom(){
    this.comp.list.push(this.com);
    this.route.navigate(['companylist']);
  }

}
