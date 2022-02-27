import { HttpClientModule } from '@angular/common/http';
import { Component,  NgModule,  OnInit  } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { HotelService } from '../services/Hotel.service';
 import { SharedModule } from '../shared/shared.module';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})


export class SearchComponent implements OnInit {

  SearchByAddress:string='';
   constructor( private router:Router , public sharedModule:SharedModule) { }
 

  ngOnInit(): void {
 
  }
  // searchFormControl = new FormControl('', [Validators.required, Validators.email])

 goToCards(){
     
     this.router.navigate(['client','hotel',this.SearchByAddress] );
  }
  
  }

