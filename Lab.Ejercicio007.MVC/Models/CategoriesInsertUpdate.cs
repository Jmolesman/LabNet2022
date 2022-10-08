using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Ejercicio007.MVC.Models
{
    public class CategoriesInsertUpdate
    {
        [Key]
        [Required(AllowEmptyStrings =true)]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "The name of the category cannot be null or empty")]
        [StringLength(15,ErrorMessage ="The category name cannot have more than 15 characters",MinimumLength =1)]
        [Display(Name ="Category Name: ")]
        public string CategoryName { get; set; }

        [StringLength(200,ErrorMessage = "The description is too long, use 200 characters.")]
        [Display(Name = "Category Description: ")]
        public string Description { get; set; }
    }
}