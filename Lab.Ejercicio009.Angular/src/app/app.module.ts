import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { ToastrModule } from 'ngx-toastr';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeScreenComponent } from './components/home-screen/home-screen.component';
import { CategoriesListComponent } from './components/categories/categories-list/categories-list.component';
import { ProductsListComponent } from './components/products/products-list/products-list.component';
import { SuppliersListComponent } from './components/suppliers/suppliers-list/suppliers-list.component';



@NgModule({
  declarations: [
    AppComponent,
    HomeScreenComponent,
    CategoriesListComponent,
    ProductsListComponent,
    SuppliersListComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    HttpClientModule,
    ToastrModule.forRoot(),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
