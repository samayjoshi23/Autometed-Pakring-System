import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { parkingDetail } from '../Models/parkingDetail.model';

@Injectable({
  providedIn: 'root'
})
export class ParkingDetailServiceService {

  baseUrl : string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getParkingDetailes():Observable<parkingDetail[]>{
    return this.http.get<parkingDetail[]>(`${this.baseUrl}/api/details`);
  }

  setParkingSlot(id: number, slotId: number, type: string):Observable<parkingDetail>{
    let options = {
      sId : slotId,
      parkType: type
    }
    return this.http.put<parkingDetail>(`${this.baseUrl}/api/details/${id}/${slotId}?type=${type}`, options);
  }
}
