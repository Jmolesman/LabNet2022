using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab.Ejercicio007.MVC.Models
{
    public class ProductsInsertUpdate
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage ="The name of the product cannot be empty")]
        [StringLength(40,ErrorMessage ="The name of the product cannot have more than 40 characters",MinimumLength = 1)]
        [Display(Name ="Product Name: ")]
        public string ProductName { get; set; }

        [Display(Name = "Supplier: ")]
        public int? SupplierID { get; set; }

        [Display(Name = "Category: ")]
        public int? CategoryID { get; set; }

        public List<SuppliersResponse> ListOfSuppliers { get; set; }
        public List<CategoriesResponse> ListOfCategories { get; set; }

        [MaxLength(20, ErrorMessage = "The detail of the quantity cannot have more than 20 characters")]
        [Display(Name = "Quantity Per Unit: ")]
        public string QuantityPerUnit { get; set; }

        [DataType(DataType.Currency,ErrorMessage = "Unit price must be entered as currency")]
        [Display(Name = "Unit Price: ")]
        [MaxLength(9)]
        public decimal? UnitPrice { get; set; }

        [Display(Name = "Units In Stock: ")]
        [MaxLength(9)]
        public short? UnitsInStock { get; set; }

        [Display(Name = " Discontinued")]
        public bool Discontinued { get; set; }
    }
}