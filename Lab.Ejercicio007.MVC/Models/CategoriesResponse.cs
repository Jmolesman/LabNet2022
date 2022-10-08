using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Ejercicio007.MVC.Models
{
    public class CategoriesResponse
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }
    }

    public class CategoriesResponseForProducts
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

    }
}