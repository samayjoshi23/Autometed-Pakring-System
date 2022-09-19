import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboardComponent } from './Components/admin-dashboard/admin-dashboard.component';
import { HomePageComponent } from './Components/home-page/home-page.component';
import { ParkVehicleComponent } from './Components/parking-details/park-vehicle/park-vehicle.component';
import { ParkingDetailsComponent } from './Components/parking-details/parking-details.component';
import { ParkingRulesComponent } from './Components/parking-rules/parking-rules.component';
import { ParkingSummaryComponent } from './Components/parking-summary/parking-summary.component';
import { UnparkVehicleComponent } from './Components/unpark-vehicle/unpark-vehicle.component';

const routes: Routes = [
  {
    path: '',
    component: HomePageComponent
  },
  {
    path: 'parkingSummary',
    component: ParkingSummaryComponent
  },
  {
    path: 'parkingDetails',
    component: ParkingDetailsComponent
  },
  {
    path: 'parkingDetails/:fid/:sid',
    component: ParkVehicleComponent
  },
  {
    path: 'parkVehicle',
    component: ParkingRulesComponent
  },
  {
    path: 'unparkVehicle',
    component: UnparkVehicleComponent
  },
  {
    path: 'admin',
    component: AdminDashboardComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
