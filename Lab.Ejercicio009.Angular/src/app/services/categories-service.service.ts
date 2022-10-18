import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';

import { environment } from 'src/environments/environment';
import { CategoryModel } from '../models/categoryModel';

@Injectable({
  providedIn: 'root'
})
export class CategoriesServiceService {

  endPoint: string = environment.apiTP8 + 'api/Categories';
  constructor(private http: HttpClient) { }

  
  /*
  GET api/Categories	      getall  ->  nada
  GET api/Categories/{id}	  get     ->  id
  POST api/Categories	      add     ->  objeto
  PUT api/Categories	      update  ->  objeto
  POST api/Categories/{id}  delete  ->  id
  */

  getCategoriesList() : Observable<any>
  {
    return this.http.get(this.endPoint);
  }

  getCategory(request: number) : Observable<any>
  {
    return this.http.get(this.endPoint + '/' + request);
  }

  addCategories(request: CategoryModel) : Observable<any>
  {
    return this.http.post(this.endPoint, request);
  }

  updateCategories(request: CategoryModel) : Observable<any>
  {
    return this.http.put(this.endPoint, request);
  }

  deleteCategories(request: number) : Observable<any>
  {
    return this.http.post(this.endPoint + '/' + request,"");
  }
}
