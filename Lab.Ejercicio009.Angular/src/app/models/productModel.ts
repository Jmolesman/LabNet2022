export class ProductModel
{
    ProductID: number = 0;
    ProductName: string = '';
    QuantityPerUnit!: string;
    UnitPrice!: number;
    UnitsInStock!: number;
    Discontinued: boolean = false;
    SupplierID!: number;
    CategoryID!: number;
}
