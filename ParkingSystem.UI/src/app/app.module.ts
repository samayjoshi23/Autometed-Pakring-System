import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './Components/home-page/home-page.component';
import { ParkingDetailsComponent } from './Components/parking-details/parking-details.component';
import { UnparkVehicleComponent } from './Components/unpark-vehicle/unpark-vehicle.component';
import { ParkingSummaryComponent } from './Components/parking-summary/parking-summary.component';
import { HttpClientModule } from '@angular/common/http';
import { ParkingRulesComponent } from './Components/parking-rules/parking-rules.component';
import { ParkVehicleComponent } from './Components/parking-details/park-vehicle/park-vehicle.component';
import { FormsModule } from '@angular/forms';
import { AdminDashboardComponent } from './Components/admin-dashboard/admin-dashboard.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    ParkingDetailsComponent,
    UnparkVehicleComponent,
    ParkingSummaryComponent,
    ParkingRulesComponent,
    ParkVehicleComponent,
    AdminDashboardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
