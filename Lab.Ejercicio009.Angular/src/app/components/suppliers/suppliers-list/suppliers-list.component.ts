import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

import { SupplierModel } from 'src/app/models/supplierModel';

import { SuppliersServiceService } from 'src/app/services/suppliers-service.service';

@Component({
  selector: 'app-suppliers-list',
  templateUrl: './suppliers-list.component.html',
  styleUrls: ['./suppliers-list.component.css']
})
export class SuppliersListComponent implements OnInit {


  supplierForm: FormGroup;
  
  get supplierCompanyNameFormControl(): FormGroup {
    return this.supplierForm.get('supplierCompanyName') as FormGroup;
  }
  
  get supplierContactNameFormControl(): FormGroup {
    return this.supplierForm.get('supplierContactName') as FormGroup;
  }

  get supplierContactTitleFormControl(): FormGroup {
    return this.supplierForm.get('supplierContactTitle') as FormGroup;
  }
  
  get supplierCompanyName(): string {
    return this.supplierCompanyNameFormControl.value;
  }

  get supplierContactName(): string {
    return this.supplierContactNameFormControl.value;
  }
  
  get supplierContactTitle(): string {
    return this.supplierContactTitleFormControl.value;
  }


  set supplierCompanyName(companyName: string) {
    this.supplierCompanyName = companyName;
  }
  
  set supplierContactName(contactName: string) {
    this.supplierContactName = contactName;
  }

  set supplierContactTitle(contactTitle: string) {
    this.supplierContactTitle = contactTitle;
  }
  
  suppliersList: SupplierModel [] = [];
  supplierToUpdate: SupplierModel;

  showList: boolean = true;
  showInsert: boolean = false;
  showUpdate: boolean = false;
  DbConnection: boolean = false;

  constructor(private readonly fb: FormBuilder, private suppliersService: SuppliersServiceService, private toastr: ToastrService) { 

    this.supplierForm = this.fb.group({
      supplierCompanyName: new FormControl('',[Validators.required,Validators.maxLength(40)]),
      supplierContactName: new FormControl('',Validators.maxLength(30)),
      supplierContactTitle: new FormControl('',Validators.maxLength(30) )
    });
    this.showSuppliersList();
    this.supplierToUpdate = new SupplierModel;
  }


  ngOnInit(): void {
  }

  checkDbConnection(): boolean
  {
    return this.DbConnection;
  }

  showInsertSupplierForm(): void {
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

  showUpdateSupplierForm(supplierUpdate: SupplierModel): void {
    if(this.checkDbConnection())
    {
      this.loadUpdateForm(supplierUpdate);
      this.showList = false;
      this.showInsert = false;
      this.showUpdate = true;
    }
  }
  
  loadUpdateForm(supplierUpdate: SupplierModel): void {
    this.supplierToUpdate = supplierUpdate;
    this.supplierForm.setValue({
      supplierCompanyName: this.supplierToUpdate.CompanyName,
      supplierContactName: this.supplierToUpdate.ContactName,
      supplierContactTitle: this.supplierToUpdate.ContactTitle
    });
  }
  
  showSuppliersList(): void {
    this.showList = true;
    this.showInsert = false;
    this.showUpdate = false;

    this.resetFormControls();

    this.suppliersService.getSuppliersList().subscribe(
      (Response) => {
        this.suppliersList = Response;
        this.DbConnection = true;
       },
      (error) => { this.DbConnection = false; });
  }
  

  onClickInsertSupplier(): void {
    if (this.supplierForm.valid)
    {
      var newSupplier = new SupplierModel;
      newSupplier.CompanyName = this.supplierCompanyName;
      newSupplier.ContactName = this.supplierContactName;
      newSupplier.ContactTitle = this.supplierContactTitle;
  
      this.suppliersService.addSuppliers(newSupplier).subscribe(
        (response) => 
        {
          if(response.includes("successfully"))
          {
            this.showSuppliersList();
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
      this.toastr.error("Error inserting the new supplier, please check the data entered in the fields.","Error")
    }

  }

  onClickUpdateSupplier(): void {
    if (this.supplierForm.valid)
    {
      this.supplierToUpdate.CompanyName = this.supplierCompanyName;
      this.supplierToUpdate.ContactName = this.supplierContactName;
      this.supplierToUpdate.ContactTitle = this.supplierContactTitle;

      this.suppliersService.updateSuppliers(this.supplierToUpdate).subscribe(
        (response) => 
        {
          if(response.includes("successfully"))
          {
            this.showSuppliersList();
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
      this.toastr.error("Error updating the supplier, please check the data entered in the fields.","Error")
    }
  }

  onClickDeleteSupplier(supplierDelete: SupplierModel): void{
    if (confirm("Are you sure to delete this supplier?"))
    {
      this.suppliersService.deleteSuppliers(supplierDelete.SupplierID).subscribe(
        (response) =>
        {
          if(response.includes("successfully"))
          {
            this.showSuppliersList();
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
    this.supplierForm.reset();
    this.supplierToUpdate = new SupplierModel;
  }
}
