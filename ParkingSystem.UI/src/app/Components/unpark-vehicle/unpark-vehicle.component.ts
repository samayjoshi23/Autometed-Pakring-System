import { Component, OnInit } from '@angular/core';
import { CustomerVehicle } from 'src/app/Models/CustomerInfo.model';
import { ParkingDetailServiceService } from 'src/app/Services/parking-detail-service.service';
import { ParkingSummaryServiceService } from 'src/app/Services/parking-summary-service.service';
import { VehicleServiceService } from 'src/app/Services/vehicle-service.service';

@Component({
  selector: 'app-unpark-vehicle',
  templateUrl: './unpark-vehicle.component.html',
  styleUrls: ['./unpark-vehicle.component.css'],
})
export class UnparkVehicleComponent implements OnInit {
  VehicleOwnerInfo: CustomerVehicle = {
    vehicle_Id: '',
    customerId: 0,
    owner_Name: '',
    vehicle_Number: '',
    floorId: 0,
    slotId: 0,
    parkingTime: null,
    unparkingTime: null,
    parkingPin: 0,
  };

  EnteredId: number | null = null;
  EnteredPin: number | null = null;

  Disability: boolean = true;
  Validity: string = '';

  constructor(
    private parkingDetailService: ParkingDetailServiceService,
    private parkingSummaryService: ParkingSummaryServiceService,
    private vehicleService: VehicleServiceService
  ) {}

  ngOnInit(): void {}
  
  sendData(fid : number, sid: number ){
    this.parkingDetailService
      .setParkingSlot(fid, sid, 'unpark')
      .subscribe({
        next: (data) => {
          console.log(data);
        },
        error: (response) => {
          console.log(response);
        },
      });

    this.parkingSummaryService
      .updateParkingSummary(fid, 'unpark')
      .subscribe({
        next: (data) => {
        console.log(data);
      },
      error: (response) => {
        console.log(response);
      }
    });
  }

  submitData() {
    this.vehicleService
      .validateVehicle(this.EnteredId, this.EnteredPin)
      .subscribe({
        next: (info) => {
          this.VehicleOwnerInfo = info;
          this.Validity = 'valid';
          this.VehicleOwnerInfo = info;
          this.sendData(info.floorId, info.slotId);
        },
        error: (response) => {
          if (response.status === 404) {
            this.Validity = 'invalid';
          }
          if (response.status === 401) {
            this.Validity = 'invalid';
          }
        },
      });
  }
}
