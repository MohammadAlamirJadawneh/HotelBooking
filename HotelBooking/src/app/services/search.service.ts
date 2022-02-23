import { Injectable } from '@angular/core';
import { SearchComponent } from '../search/search.component';

@Injectable({
  providedIn: 'root'
})
export class SearchService {

  constructor(private searchComponent :SearchComponent) { }
  SearchByAddress:string|undefined=this.searchComponent.SearchByAddress;

}
