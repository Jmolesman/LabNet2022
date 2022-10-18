import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormControlName, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

import { CategoryModel } from 'src/app/models/categoryModel';

import { CategoriesServiceService } from 'src/app/services/categories-service.service';

@Component({
  selector: 'app-categories-list',
  templateUrl: './categories-list.component.html',
  styleUrls: ['./categories-list.component.css']
})
export class CategoriesListComponent implements OnInit {

  categoryForm: FormGroup;
  
  get categoryNameFormControl(): FormGroup {
    return this.categoryForm.get('categoryName') as FormGroup;
  }
  
  get categoryDescriptionFormControl(): FormGroup {
    return this.categoryForm.get('description') as FormGroup;
  }

  get categoryName(): string {
    return this.categoryNameFormControl.value;
  }
  
  get categoryDescription(): string {
    return this.categoryDescriptionFormControl.value;
  }

  set categoryName(name: string) {
    this.categoryName = name;
  }
  
  set categoryDescription(description: string) {
    this.categoryDescription = description;
  }
  
  categoriesList: CategoryModel [] = [];
  categoryToUpdate: CategoryModel;

  showList: boolean = true;
  showInsert: boolean = false;
  showUpdate: boolean = false;
  DbConnection: boolean = false;

  constructor(private readonly fb: FormBuilder, private categoriesService: CategoriesServiceService, private toastr: ToastrService) { 

    this.showCategoriesList();
    this.categoryToUpdate = new CategoryModel;
    this.categoryForm = this.fb.group({
      categoryName: new FormControl('',[Validators.required,Validators.maxLength(15)]),
      description: new FormControl('',Validators.maxLength(200))
    });
  }


  ngOnInit(): void {
  }

  checkDbConnection(): boolean
  {
    return this.DbConnection;
  }

  showInsertCategoryForm(): void {
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

  showUpdateCategoryForm(categoryUpdate: CategoryModel): void {
    if(this.checkDbConnection())
    {
      this.loadUpdateForm(categoryUpdate);
      this.showList = false;
      this.showInsert = false;
      this.showUpdate = true;
    }
  }
  
  loadUpdateForm(categoryUpdate: CategoryModel): void {
    this.categoryToUpdate = categoryUpdate;
    this.categoryForm.setValue({
      categoryName: this.categoryToUpdate.CategoryName,
      description: this.categoryToUpdate.Description
    });
  }
  
  showCategoriesList(): void {
    this.showList = true;
    this.showInsert = false;
    this.showUpdate = false;

    this.categoriesService.getCategoriesList().subscribe(
      (Response) => {
        this.categoriesList = Response;
        this.DbConnection = true;
        },
      (Error) => { this.DbConnection = false; });
  }
  

  onClickInsertCategory(): void {
    if(this.categoryForm.valid)
    {
      var newCategory = new CategoryModel;
      newCategory.CategoryName = this.categoryName;
      newCategory.Description = this.categoryDescription;

      this.categoriesService.addCategories(newCategory).subscribe(
        (response) => 
        {
          if(response.includes("successfully"))
          {
            this.showCategoriesList();
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
      this.toastr.error("Error inserting the new category, please check the data entered in the fields.","Error")
    }
  }

  onClickUpdateCategory(): void {
    if (this.categoryForm.valid)
    {
      this.categoryToUpdate.CategoryName = this.categoryName;
      this.categoryToUpdate.Description = this.categoryDescription;
  
      this.categoriesService.updateCategories(this.categoryToUpdate).subscribe(
        (response) => 
        {
          if(response.includes("successfully"))
          {
            this.showCategoriesList();
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
      this.toastr.error("Error updating the category, please check the data entered in the fields.","Error")
    }
  }

  onClickDeleteCategory(categoryDelete: CategoryModel): void{
    console.log(categoryDelete.CategoryID);
    if (confirm("Are you sure to delete this category?"))
    {
      this.categoriesService.deleteCategories(categoryDelete.CategoryID).subscribe(
        (response) =>
        {
          if(response.includes("successfully"))
          {
            this.showCategoriesList();
            this.toastr.success(response,"Success")
          }},
        (error) =>
        {
            this.toastr.error(error.error,"Error")
        });
    }
  }

  resetFormControls()
  {
    this.categoryForm.reset();
  }
}
