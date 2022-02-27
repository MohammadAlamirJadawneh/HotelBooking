import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { HotelsComponent } from './home/Hotels/Hotels.component';
import { ProfileComponent } from './profile/profile.component';

const routes: Routes = [{
  path: "",
  component: HomeComponent
},
{
  path: "hotel/:search",
  component: HotelsComponent  
},
 {
  path: "profile",
  component: ProfileComponent
},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ClientRoutingModule { }
