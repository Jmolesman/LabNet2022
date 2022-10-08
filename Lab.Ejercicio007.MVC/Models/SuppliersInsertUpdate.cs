using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Ejercicio007.MVC.Models
{
    public class SuppliersInsertUpdate
    {
        [Key]
        public int SupplierID { get; set; }

        [Required]
        [StringLength(40,ErrorMessage = "The name of the company cannot have more than 40 characters",MinimumLength = 1)]
        [Display(Name = "Company Name: ")]
        public string CompanyName { get; set; }

        [StringLength(30, ErrorMessage = "The name of the company contact cannot have more than 30 characters", MinimumLength = 1)]
        [Display(Name = "Contact Name: ")]
        public string ContactName { get; set; }

        [StringLength(30, ErrorMessage = "The title of the company contact cannot have more than 30 characters", MinimumLength = 1)]
        [Display(Name = "Contact Title: ")]
        public string ContactTitle { get; set; }
    }
}