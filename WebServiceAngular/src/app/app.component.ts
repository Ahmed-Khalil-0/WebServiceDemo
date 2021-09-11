import { Component } from '@angular/core';
import 'rxjs'
import {EmployeeServiceService} from 'src/app/services/employee-service.service'
import {EmployeeModel} from 'src/app/model/employee-model'
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(private employeeService: EmployeeServiceService) {
      console.log(" ia m in the app compnoneb");

      this.employeeService.getAllEmplyees().subscribe(
        (employees) => {console.log(employees)}
      );
  }
  title = 'WebServiceAngular';
}
