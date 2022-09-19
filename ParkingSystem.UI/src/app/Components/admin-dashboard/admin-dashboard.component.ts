import { Component, OnInit } from '@angular/core';
import { VehicleServiceService } from 'src/app/Services/vehicle-service.service';

@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css']
})
export class AdminDashboardComponent implements OnInit {

  adminInfo: any = {}

  constructor(private vehicleListService : VehicleServiceService) { }

  ngOnInit(): void {
    this.vehicleListService.getAllVehicelInfo().subscribe({
      next: (data) => {
        this.adminInfo = data;
        console.log(data);
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

}
