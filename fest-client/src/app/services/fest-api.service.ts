import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment'
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { FestApiResponse } from '../models/fest-api-response';

@Injectable({
  providedIn: 'root'
})
export class FestApiService {
  constructor(private _http: HttpClient) {
      
  }

  generateToken(): void {
    // let url = environment.apiBaseUrl + 'Weather?ZipCode=10001&Units=Metric'
  }

  getWeather(zipCode: string, units: string = 'metric'): Observable<FestApiResponse> {
    const url = environment.apiBaseUrl + `Weather?ZipCode=${zipCode}&Units=${units}`;

    return this._http.get<FestApiResponse>(url);
  }
}
