import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomeScreenComponent } from './components/home-screen/home-screen.component';
import { CategoriesListComponent } from './components/categories/categories-list/categories-list.component';
import { ProductsListComponent } from './components/products/products-list/products-list.component';
import { SuppliersListComponent } from './components/suppliers/suppliers-list/suppliers-list.component';

const routes: Routes = [
  {path: '', redirectTo: 'home-screen', pathMatch:'full'},
  
  {path: 'categories', component: CategoriesListComponent},
  {path: 'products', component: ProductsListComponent},
  {path: 'suppliers', component: SuppliersListComponent},
  {path: 'home-screen', component: HomeScreenComponent},
  
  {path: '**', redirectTo: 'home-screen', pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
