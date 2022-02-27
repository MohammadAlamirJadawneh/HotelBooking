import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './footer/footer.component';
import { NavigationBarComponent } from './navigation-bar/navigation-bar.component';
import { SharedModule } from './shared/shared.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SearchComponent } from './search/search.component';
 
import { FormsModule } from '@angular/forms';
 
@NgModule({
  declarations: [
    AppComponent,
    NavigationBarComponent,
    FooterComponent,
    SearchComponent 
     
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    SharedModule,
     BrowserAnimationsModule,
     FormsModule
  ],exports: [
    BrowserModule,
    AppRoutingModule,
     SharedModule,
     BrowserAnimationsModule,
   FormsModule
  ],
  providers: [//SearchService,HotelService 
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
