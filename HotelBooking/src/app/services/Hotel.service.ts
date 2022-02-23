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
  SearchByAddress:string ;
  constructor(private http: HttpClient ,
   ) {
 this.SearchByAddress ="";

  }

  baseUrl = 'https://localhost:44338/api/Hotel/GetHotelByAddress/';
  
  headers = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    }),
    withCredentials: true,
  };
   //hotels :Hotels|undefined;
 // GetHotelByAddress()   {
     GetHotelByAddress(): Observable<Hotels[]> {
    return  this.http.get<Hotels[]>(this.baseUrl +encodeURI('amman') ).pipe();
  //  return this.http.get<Hotels[]>(this.baseUrl +  'amman'   ).pipe();
  

 

  // encodeURI('Aqaba')
 
 /*
    const values = this.http.get<Hotels>(this.baseUrl +encodeURI('irbid') ).pipe();
    values.subscribe(data=>{
     
    console.log('data'+data);
     
  })

   return values;
   */
  }
}
