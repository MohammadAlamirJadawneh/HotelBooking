import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
  import { Router } from '@angular/router';
import { HotelService } from 'src/app/services/Hotel.service';
import { Hotels } from 'src/app/models/hotels/hotels.module';
import { Observable } from 'rxjs';
@Component({
  selector: 'app-Hotels',
  templateUrl: './Hotels.component.html',
  styleUrls: ['./Hotel.component.css']
})
export class HotelsComponent implements OnInit {
   constructor( public hotelService:HotelService ) {
     this.hotels=[]
    }
   hotels:Hotels[]  ;
    // async ngOnInit():  Promise <void> {

    //   await this.hotelService.GetHotelByAddress().subscribe((item)=>{
    //     this.hotels=item;         
    //  });
    ngOnInit():void{
      this.GetHotels();
           }
      
          async  GetHotels(): Promise <void> {
              await  this.hotelService.GetHotelByAddress().subscribe((item) => {
                console.log('item',item)
                 
                  this.hotels=item;
                  console.log('this.hotels',this.hotels)
                  
                  
               
                
                
                // this.hotels=item
                // console.log('this.hotels',  this.hotels);
              });

/*        this.hotelService.GetHotelByAddress().forEach(mobile => {
              for (let i in mobile) {
                  console.log(`${i}: ${mobile[i]}`);
              }
          });
          */
            // console.log( "object", Object.values(item) );

            //  var y= Object.entries(item)  ;
           

             // const hotels= Object.entries(item) 
             

        
              
             //console.log(anyAdult); 
            
          }
          
          
          
/*
  async ngOnInit(): Promise<void> {
 




  await this.hotelService.GetHotelByAddress().subscribe((item) => {
      this.hotels=item ;
      console.log('item', item);
     });
  
   }
 
  */
    
    
  }


//   @Input() HotelName: string | undefined;
//   @Input() HotelPrice: number | undefined;
//   @Input() HotelDiscount: number | undefined;
//   @Input() HotelDescription:string |undefined;
//   @Input() HotelRank:number |undefined;

// @Output() openProfile = new EventEmitter();
//   showUserProfile() {
//     // this.homeService.selectedUser={
//     //   HotelName:this.HotelName,
//     //   HotelPrice: this.HotelPrice,
//     //   HotelDiscount: this.HotelDiscount,
//     //   HotelDescription: this.HotelDescription, 
//     //   HotelRank: this.HotelRank 
  
//     }
//     this.openProfile.emit();
 
