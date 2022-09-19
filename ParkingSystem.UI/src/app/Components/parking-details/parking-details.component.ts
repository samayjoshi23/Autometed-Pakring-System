import { Component, OnInit } from '@angular/core';
import { parkingDetail } from 'src/app/Models/parkingDetail.model';
import { ParkingDetailServiceService } from 'src/app/Services/parking-detail-service.service';

@Component({
  selector: 'app-parking-details',
  templateUrl: './parking-details.component.html',
  styleUrls: ['./parking-details.component.css'],
})
export class ParkingDetailsComponent implements OnInit {
  parkingFloorDetails: parkingDetail[] = [];

  constructor(private DetailedService: ParkingDetailServiceService) {}

  ngOnInit(): void {
    this.DetailedService.getParkingDetailes().subscribe({
      next: (summary) => {
        this.parkingFloorDetails = summary;
        console.log(summary);
        this.parkingFloorDetails.forEach(element => {
          element.allSlots = [];
          element.allSlots.push(element.slot1)
          element.allSlots.push(element.slot2)
          element.allSlots.push(element.slot3)
          element.allSlots.push(element.slot4)
          element.allSlots.push(element.slot5)
          element.allSlots.push(element.slot6)
          element.allSlots.push(element.slot7)
          element.allSlots.push(element.slot8)
          element.allSlots.push(element.slot9)
          element.allSlots.push(element.slot10)
          element.allSlots.push(element.slot11)
          element.allSlots.push(element.slot12)
          element.allSlots.push(element.slot13)
          element.allSlots.push(element.slot14)
          element.allSlots.push(element.slot15)
          element.allSlots.push(element.slot16)
          element.allSlots.push(element.slot17)
          element.allSlots.push(element.slot18)
          element.allSlots.push(element.slot19)
          element.allSlots.push(element.slot20)
        });
      },
      error: (response) => {
        console.log(response);
      },
    });
  }
}
