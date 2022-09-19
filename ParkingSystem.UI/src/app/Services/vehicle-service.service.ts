import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CustomerVehicle } from '../Models/CustomerInfo.model';

@Injectable({
  providedIn: 'root'
})
export class VehicleServiceService {

  baseUrl : string = environment.baseApiUrl;
  constructor(private http: HttpClient) { }


  getAllVehicelInfo(): Observable<any>{
    return this.http.get<any>(`${this.baseUrl}/admin`);
  }

  validateVehicle(parkingId: number | null, parkingPin: number | null) : Observable<CustomerVehicle>{
    return this.http.put<CustomerVehicle>(`https://localhost:7037/api/parkingHistory/${parkingId}?pin=${parkingPin}`, parkingPin);
  }

  addVehicle(vehcleInfo : CustomerVehicle):Observable<CustomerVehicle> {
    return this.http.post<CustomerVehicle>(`${this.baseUrl}/api/parkingHistory`, vehcleInfo);
  }

}
