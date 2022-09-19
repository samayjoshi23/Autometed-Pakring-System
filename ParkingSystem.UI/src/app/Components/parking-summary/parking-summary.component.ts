import { Component, OnInit } from '@angular/core';
import { parkingSummary } from 'src/app/Models/parkingSummary.model';
import { ParkingSummaryServiceService } from 'src/app/Services/parking-summary-service.service';

@Component({
  selector: 'app-parking-summary',
  templateUrl: './parking-summary.component.html',
  styleUrls: ['./parking-summary.component.css']
})
export class ParkingSummaryComponent implements OnInit {

  ParkingZones: parkingSummary[] = [];

  constructor(private SummaryService: ParkingSummaryServiceService) { }

  ngOnInit(): void {
    this.SummaryService.getParkingSummary().subscribe({
      next: (summary) => {
        this.ParkingZones = summary;
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

}
