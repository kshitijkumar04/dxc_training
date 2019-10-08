import { Injectable } from '@angular/core';
import {Company} from './company';
@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  constructor() { }
  list:Company[]=[
    {deptid:1,name:'Engineering',groupname:'Research & Development',date:new Date()},
    {deptid:2,name:'Tool Design',groupname:'Research & Development',date:new Date()},
    {deptid:3,name:'Sales',groupname:'Sales & Marketing',date:new Date()}
  ];
     showcompany(){
       return this.list;
     }
  }

