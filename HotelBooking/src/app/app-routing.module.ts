import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SearchComponent } from './search/search.component';


const routes: Routes = [
  {
    path: "",
    component: SearchComponent
  },
  {
  path:"client",
  loadChildren:()=>import ('./client/client.module').then((m)=>m.ClientModule)
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
