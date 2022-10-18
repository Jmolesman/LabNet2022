import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';

import { environment } from 'src/environments/environment';
import { ProductModel } from '../models/productModel';

@Injectable({
  providedIn: 'root'
})
export class ProductsServiceService {
  
  endPoint: string = environment.apiTP8 + 'api/Products';
  constructor(private http: HttpClient) { }

  getProductsList() : Observable<any>
  {
    return this.http.get(this.endPoint);
  }

  getProduct(request: number) : Observable<any>
  {
    return this.http.get(this.endPoint + '/' + request);
  }

  addProducts(request: ProductModel) : Observable<any>
  {
    return this.http.post(this.endPoint, request);
  }

  updateProducts(request: ProductModel) : Observable<any>
  {
    return this.http.put(this.endPoint, request);
  }

  deleteProducts(request: number) : Observable<any>
  {
    return this.http.post(this.endPoint + '/' + request,"");
  }
}
