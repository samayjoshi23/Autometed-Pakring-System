import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { parkingSummary } from '../Models/parkingSummary.model';

@Injectable({
  providedIn: 'root'
})
export class ParkingSummaryServiceService {

  baseUrl : string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getParkingSummary():Observable<parkingSummary[]>{
    return this.http.get<parkingSummary[]>(`${this.baseUrl}/api/summary`);
  }

  updateParkingSummary(zId : number, type: string):Observable<parkingSummary> {
    return this.http.put<parkingSummary>(`${this.baseUrl}/api/summary/${zId}?type=${type}`, type);
  }
}
