import { NgModule } from '@angular/core';
//import { CommonModule } from '@angular/common';

import { ClientRoutingModule } from './client-routing.module';
//import { HomeComponent } from './home/home.component';
// import {MatToolbarModule} from '@angular/material/toolbar';
// import {MatCardModule} from '@angular/material/card';

// import {MatButtonModule} from '@angular/material/button';
import { HotelsComponent } from './home/Hotels/Hotels.component';
import { ProfileComponent } from './profile/profile.component';
import { SharedModule } from '../shared/shared.module';
 
 import { HttpClientModule } from '@angular/common/http';
import { SearchService } from '../services/search.service';
import { HotelService } from '../services/Hotel.service';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    HomeComponent,
    HotelsComponent,
    ProfileComponent
  ],
  imports: [
    ClientRoutingModule ,
    SharedModule ,
    
   
    
  ],  providers: [SearchService,HotelService],

})
export class ClientModule { }
