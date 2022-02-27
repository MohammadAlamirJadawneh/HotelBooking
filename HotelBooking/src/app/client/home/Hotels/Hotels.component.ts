import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HotelService } from 'src/app/services/Hotel.service';
import { Hotels } from 'src/app/models/hotels/hotels.module';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-Hotels',
  templateUrl: './Hotels.component.html',
  styleUrls: ['./Hotel.component.css']
})
export class HotelsComponent implements OnInit {
  constructor(public hotelService: HotelService, public route: ActivatedRoute) {
    this.hotels = []
    this.headers = []

  }
  hotels: any[];
  headers: any[];
 

  async ngOnInit(): Promise<void> {
     
   const search = this.route.snapshot.paramMap.get('search');
   console.log(search);
   if(search)
    this.GetHotels(search);



  }

  async GetHotels(search :string ): Promise<void> {
    this.hotelService.GetHotelByAddress(search).subscribe((item) => {
     // console.log('item', item[0].HotelName);
      this.hotels = item;

      console.log('this.hotels', this.hotels);


    
    });
 
  }


 

}


