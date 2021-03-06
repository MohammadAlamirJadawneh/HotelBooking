import { HttpBackend, HttpClient, HttpEvent, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { Hotels } from '../models/hotels/hotels.module';
import { SearchComponent } from '../search/search.component';
import { SearchService } from './search.service';
import { SharedModule } from '../shared/shared.module';
@Injectable({
  providedIn: 'root'
})
export class HotelService {

  SearchByAddress: string="";
  constructor(private http: HttpClient
  ) {
 
  }

  baseUrl = 'https://localhost:44338/api/Hotel/GetHotelByAddress/';

  headers = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    }),
    withCredentials: true,
  };

  GetHotelByAddress(search: string): Observable<Hotels[]> {
 
    return this.http.get<Hotels[]>(this.baseUrl + search);

  }
}
