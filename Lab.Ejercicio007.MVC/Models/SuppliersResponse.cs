﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Ejercicio007.MVC.Models
{
    public class SuppliersResponse
    {
        public int SupplierID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }
    }
}