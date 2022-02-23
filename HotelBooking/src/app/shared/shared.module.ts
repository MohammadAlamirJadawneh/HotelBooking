import {  NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatCardModule } from '@angular/material/card';
import { MatToolbarModule } from '@angular/material/toolbar';
import { HttpClient } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';
import { SearchService } from '../services/search.service';
import { HotelService } from '../services/Hotel.service';
import { SearchComponent } from '../search/search.component';
 
 
@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    FormsModule,
  
    MatFormFieldModule,
    MatInputModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatProgressSpinnerModule ,
    MatToolbarModule,
    MatCardModule,
    HttpClientModule
   ],
  exports: [  
    CommonModule,
    FormsModule,
  
    MatFormFieldModule,
    MatInputModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatProgressSpinnerModule ,
    MatToolbarModule,
    MatCardModule,
    HttpClientModule

  ],
  providers:[SearchService,HotelService]
})
export class SharedModule {  
   constructor(public http: HttpClient ) { }
}
