import { Component, OnInit } from '@angular/core';
import{Company} from '../company';
import{CompanyService} from '../company.service';
@Component({
  selector: 'app-companylist',
  templateUrl: './companylist.component.html',
  styleUrls: ['./companylist.component.css']
})
export class CompanylistComponent implements OnInit {

  list:Company[];
    com2:Company;
    show=false;
  constructor(private compp:CompanyService) {
    this.list=this.compp.showcompany();
  }

  ngOnInit() {
  }
  delete(index:number){
    this.list.splice(index,1);
  }
  edit(index:number){
      this.show=true;
      this.com2=this.compp.list[index];
  }
    addcom(){
      this.show=false;
    }

}
