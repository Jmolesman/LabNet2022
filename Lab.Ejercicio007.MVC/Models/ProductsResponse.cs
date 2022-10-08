using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Ejercicio007.MVC.Models
{
    public class ProductsResponse
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public bool Discontinued { get; set; }

    }
}