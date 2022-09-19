import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CustomerVehicle } from 'src/app/Models/CustomerInfo.model';
import { ParkingDetailServiceService } from 'src/app/Services/parking-detail-service.service';
import { ParkingSummaryServiceService } from 'src/app/Services/parking-summary-service.service';
import { VehicleServiceService } from 'src/app/Services/vehicle-service.service';

@Component({
  selector: 'app-park-vehicle',
  templateUrl: './park-vehicle.component.html',
  styleUrls: ['./park-vehicle.component.css'],
})
export class ParkVehicleComponent implements OnInit {
  floorId: number;
  slotId: number;

  VehicleOwnerInfo: CustomerVehicle = {
    vehicle_Id: '',
    customerId: 0,
    owner_Name: '',
    vehicle_Number: '',
    floorId: 0,
    slotId: 0,
    parkingTime: null,
    unparkingTime: null,
    parkingPin: null,
  };

  Validity: string = '';
  Disability: boolean = true; 


  constructor(
    private actRoute: ActivatedRoute,
    private parkingDetailService: ParkingDetailServiceService,
    private parkingSummaryService: ParkingSummaryServiceService,
    private vehicleService: VehicleServiceService,
    private router: Router
  ) {
    this.floorId = this.actRoute.snapshot.params['fid'];
    this.slotId = this.actRoute.snapshot.params['sid'];
  }

  ngOnInit(): void {}

  generateData() {
    this.VehicleOwnerInfo.vehicle_Id = '00000000-0000-0000-0000-000000000000';
    this.VehicleOwnerInfo.customerId = Math.floor(Math.random() * 100000000);
    this.VehicleOwnerInfo.floorId = this.floorId;
    this.VehicleOwnerInfo.slotId = this.slotId;
    this.VehicleOwnerInfo.parkingTime = null;
    this.VehicleOwnerInfo.unparkingTime = null;

    console.log(this.VehicleOwnerInfo);
  }

  UpdateFloorSlot() {
    this.parkingDetailService
      .setParkingSlot(this.floorId, this.slotId, 'park')
      .subscribe((data) => {
        console.log(data);
      });

    setTimeout(() => {
      (<any>this.router).navigate([`/`]);
    }, 1500);
  }

  submitData() {
    this.UpdateFloorSlot();

    this.parkingSummaryService
      .updateParkingSummary(this.floorId, 'park')
      .subscribe({
        next: (data) => {
          console.log(data);
        },
        error: (response) => {
          if (response.status === 400) {
            this.Validity = 'invalid';
          }
        },
      });

    this.vehicleService.addVehicle(this.VehicleOwnerInfo).subscribe({
      next: (data) => {
        console.log(data);
      },
      error: (response) => {
        if (response.status === 400) {
          this.Validity = 'invalid';
        }
      },
    });
  }
}
