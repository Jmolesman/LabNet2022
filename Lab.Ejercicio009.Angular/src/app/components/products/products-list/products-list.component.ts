import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { ProductModel } from 'src/app/models/productModel';
import { ProductsServiceService } from 'src/app/services/products-service.service';

@Component({
  selector: 'app-products-list',
  templateUrl: './products-list.component.html',
  styleUrls: ['./products-list.component.css']
})
export class ProductsListComponent implements OnInit {
  readonly decimalRegex: RegExp = /(?:^[1-9]([0-9]+)?(?:\.[0-9]{1,2})?$)|(?:^(?:0)$)|(?:^[0-9]\.[0-9](?:[0-9])?$)/;

  productForm: FormGroup;
  
  get productNameFormControl(): FormGroup {
    return this.productForm.get('productName') as FormGroup;
  }
  
  get productQuantityPerUnitFormControl(): FormGroup {
    return this.productForm.get('productQuantityPerUnit') as FormGroup;
  }

  get productUnitPriceFormControl(): FormGroup {
    return this.productForm.get('productUnitPrice') as FormGroup;
  }

  get productUnitsInStockFormControl(): FormGroup {
    return this.productForm.get('productUnitsInStock') as FormGroup;
  }

  get productDiscontinuedFormControl(): FormGroup {
    return this.productForm.get('productDiscontinued') as FormGroup;
  }
  
  get productName(): string {
    return this.productNameFormControl.value;
  }

  get productQuantityPerUnit(): string {
    return this.productQuantityPerUnitFormControl.value;
  }
  
  get productUnitPrice(): number {
    return this.productUnitPriceFormControl.value;
  }

  get productUnitsInStock(): number {
    return this.productUnitsInStockFormControl.value;
  }
  
  get productDiscontinued(): boolean {
    return this.productDiscontinuedFormControl.value;
  }

  set productName(name: string) {
    this.productName = name;
  }
  
  set productQuantityPerUnit(quantity: string) {
    this.productQuantityPerUnit = quantity;
  }

  set productUnitPrice(price: number){
    this.productUnitPrice = price;
  }

  set productUnitsInStock(stock: number){
    this.productUnitsInStock = stock;
  }
  
  set productDiscontinued(status: boolean) {
    this.productDiscontinued = status;
  }
  
  productsList: ProductModel [] = [];
  productToUpdate: ProductModel;

  showList: boolean = true;
  showInsert: boolean = false;
  showUpdate: boolean = false;
  DbConnection: boolean = false;

  constructor(private readonly fb: FormBuilder, private productsService: ProductsServiceService, private toastr: ToastrService) { 

    this.productForm = this.fb.group({
      productName: new FormControl('',[Validators.required,Validators.maxLength(40)]),
      productQuantityPerUnit: new FormControl('',Validators.maxLength(20)),
      productUnitPrice: new FormControl('',Validators.pattern(this.decimalRegex)),
      productUnitsInStock: new FormControl('',Validators.pattern('^[0-9]*$')),
      productDiscontinued: new FormControl('')
    });
    this.showProductsList();
    this.productToUpdate = new ProductModel;
  }


  ngOnInit(): void {
  }

  checkDbConnection(): boolean
  {
    return this.DbConnection;
  }

  showInsertProductForm(): void {
    if(this.checkDbConnection())
    {
      this.showList = false;
      this.showInsert = true;
      this.showUpdate = false;
    }
    else
    {
      this.toastr.error("Unable to insert data because the database is offline.","Error")
    }
  }

  showUpdateProductForm(productUpdate: ProductModel): void {
    if(this.checkDbConnection())
    {
      this.loadUpdateForm(productUpdate);
      this.showList = false;
      this.showInsert = false;
      this.showUpdate = true;
    }
  }
  
  loadUpdateForm(productUpdate: ProductModel): void {
    this.productToUpdate = productUpdate;
    this.productForm.setValue({
      productName: this.productToUpdate.ProductName,
      productQuantityPerUnit: this.productToUpdate.QuantityPerUnit,
      productUnitPrice: this.productToUpdate.UnitPrice,
      productUnitsInStock: this.productToUpdate.UnitsInStock,
      productDiscontinued: this.productToUpdate.Discontinued
    });
  }
  
  showProductsList(): void {
    this.showList = true;
    this.showInsert = false;
    this.showUpdate = false;

    this.resetFormControls();

    this.productsService.getProductsList().subscribe(
      (Response) => {
        this.productsList = Response;
        this.DbConnection = true;
       },
      (Error) => { this.DbConnection = false; });
  }
  

  onClickInsertProduct(): void {
    if(this.productForm.valid)
    {
      var newProduct = new ProductModel;
      newProduct.ProductName = this.productName;
      newProduct.QuantityPerUnit = this.productQuantityPerUnit;
      newProduct.UnitPrice = this.productUnitPrice;
      newProduct.UnitsInStock = this.productUnitsInStock;
      newProduct.Discontinued = this.productDiscontinued;
  
      this.productsService.addProducts(newProduct).subscribe(
        (response) => 
        {
          if(response.includes("successfully"))
          {
            this.showProductsList();
            this.resetFormControls()
            this.toastr.success(response,"Success")
          }},
        (error) =>
        {
          this.toastr.error(error.error,"Error")
        });
    }
    else
    {
      this.toastr.error("Error inserting the new product, please check the data entered in the fields.","Error")
    }
  }

  onClickUpdateProduct(): void {
    if(this.productForm.valid)
    {
      this.productToUpdate.ProductName = this.productName;
      this.productToUpdate.QuantityPerUnit = this.productQuantityPerUnit;
      this.productToUpdate.UnitPrice = this.productUnitPrice;
      this.productToUpdate.UnitsInStock = this.productUnitsInStock;
      this.productToUpdate.Discontinued = this.productDiscontinued;
  
      this.productsService.updateProducts(this.productToUpdate).subscribe(
        (response) =>  
        {
          if(response.includes("successfully"))
          {
            this.showProductsList();
            this.resetFormControls()
            this.toastr.success(response,"Success")
          }},
        (error) =>
        {
          this.toastr.error(error.error,"Error")
        });
    }
    else
    {
      this.toastr.error("Error updating the product, please check the data entered in the fields.","Error")
    }
  }

  onClickDeleteProduct(productDelete: ProductModel): void{
    console.log(productDelete.ProductID);
    if (confirm("Are you sure to delete this product?"))
    {
      this.productsService.deleteProducts(productDelete.ProductID).subscribe(
        (response) => {
          if(response.includes("successfully"))
          {
            this.showProductsList();
            this.toastr.success(response,"Success")
          }
        },
        (error) => {
          this.toastr.error(error.error,"Error")
        });
    }
  }

  resetFormControls()
  {
    this.productForm.reset();
    this.productToUpdate = new ProductModel;
  }
}
