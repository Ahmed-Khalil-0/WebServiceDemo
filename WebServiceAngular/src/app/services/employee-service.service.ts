import { Injectable } from '@angular/core';
import {HttpClient,HttpHeaders} from '@angular/common/http'

const httpOptions = {
  headers: new HttpHeaders(
    {
      'Content-Type': 'application/json'
    }
  )
}

@Injectable({
  providedIn: 'root'
})
export class EmployeeServiceService {

  constructor(private http:HttpClient) { }

  getAllEmplyees(){
    return this.http.get<any>('http://192.168.10.191/Test/calculationwebservice.asmx/GetAllEmployee');
    }
}
