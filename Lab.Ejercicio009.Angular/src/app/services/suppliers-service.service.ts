import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { SupplierModel } from '../models/supplierModel';

@Injectable({
  providedIn: 'root'
})
export class SuppliersServiceService {
  
  endPoint: string = environment.apiTP8 + 'api/Suppliers';
  constructor(private http: HttpClient) { }

  getSuppliersList() : Observable<any>
  {
    return this.http.get(this.endPoint);
  }

  getSupplier(request: number) : Observable<any>
  {
    return this.http.get(this.endPoint + '/' + request);
  }

  addSuppliers(request: SupplierModel) : Observable<any>
  {
    return this.http.post(this.endPoint, request);
  }

  updateSuppliers(request: SupplierModel) : Observable<any>
  {
    return this.http.put(this.endPoint, request);
  }

  deleteSuppliers(request: number) : Observable<any>
  {
    return this.http.post(this.endPoint + '/' + request,"");
  }
}
