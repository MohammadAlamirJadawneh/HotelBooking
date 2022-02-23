import { Component, OnInit } from '@angular/core';
import { HotelService } from 'src/app/services/Hotel.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  constructor(public hotelService:HotelService) { }

  ngOnInit(): void {
  }

}
