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

        [Required(ErrorMessage = "The name of the product cannot be null or empty")]
        [StringLength(40, ErrorMessage = "The name of the product cannot have more than 40 characters", MinimumLength = 1)]
        [Display(Name = "Product Name: ")]
        public string ProductName { get; set; }

        [StringLength(20, ErrorMessage = "The detail of the quantity cannot have more than 20 characters")]
        [Display(Name = "Quantity Per Unit: ")]
        public string QuantityPerUnit { get; set; }

        [Display(Name = "Unit Price: ")]
        public decimal? UnitPrice { get; set; }

        [Display(Name = "Units In Stock: ")]
        public short? UnitsInStock { get; set; }

        [Display(Name = " Discontinued")]
        public bool Discontinued { get; set; }
    }
}