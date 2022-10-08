using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Logic;
using Lab.Ejercicio004.EF.Utils;
using Lab.Ejercicio007.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Ejercicio007.MVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {

            List<ProductsResponse> newListOfProducts;
            ProductsLogic newProductLogic = new ProductsLogic();

            newListOfProducts = newProductLogic.GetAll().Select(p => new ProductsResponse
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                SupplierID = p.SupplierID,
                CategoryID = p.CategoryID,
                QuantityPerUnit = p.QuantityPerUnit,
                UnitPrice = p.UnitPrice,
                UnitsInStock = p.UnitsInStock,
                Discontinued = p.Discontinued
            }).OrderBy(k => k.ProductName).ToList();

            return View(newListOfProducts);
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ProductsInsertUpdate newProduct)
        {
            if (ModelState.IsValid)
            {
                Products oProduct = new Products
                {
                    ProductName = newProduct.ProductName,
                    SupplierID = newProduct.SupplierID,
                    CategoryID = newProduct.CategoryID,
                    QuantityPerUnit = newProduct.QuantityPerUnit,
                    UnitPrice = newProduct.UnitPrice,
                    UnitsInStock = newProduct.UnitsInStock,
                    Discontinued = newProduct.Discontinued
                };
                ProductsLogic newProductsLogic = new ProductsLogic();
                string status = newProductsLogic.Add(oProduct);
                return Redirect("~/Products/Index");
            }
            else
            {
                return View(newProduct);
            }
        }


        [HttpGet]
        public ActionResult Update(int? id)
        {
            if (Helpers.IdIsNotNull(id))
            {
                ProductsLogic newProductsLogic = new ProductsLogic();
                Products oProduct = newProductsLogic.GetEntityByID((int)id);
                ProductsInsertUpdate newProductUpdate = new ProductsInsertUpdate
                {
                    ProductID = oProduct.ProductID,
                    ProductName = oProduct.ProductName,
                    SupplierID = oProduct.SupplierID,
                    CategoryID = oProduct.CategoryID,
                    QuantityPerUnit = oProduct.QuantityPerUnit,
                    UnitPrice = oProduct.UnitPrice,
                    UnitsInStock = oProduct.UnitsInStock,
                    Discontinued = oProduct.Discontinued
                };
                return View(newProductUpdate);
            }
            else
            {
                return Redirect("~/Products/Index");
            }
        }

        [HttpPost]
        public ActionResult Update(ProductsInsertUpdate newProductUpdate)
        {
            if (ModelState.IsValid)
            {
                Products oProduct = new Products
                {
                    ProductID = newProductUpdate.ProductID,
                    ProductName = newProductUpdate.ProductName,
                    SupplierID = newProductUpdate.SupplierID,
                    CategoryID = newProductUpdate.CategoryID,
                    QuantityPerUnit = newProductUpdate.QuantityPerUnit,
                    UnitPrice = newProductUpdate.UnitPrice,
                    UnitsInStock = newProductUpdate.UnitsInStock,
                    Discontinued = newProductUpdate.Discontinued
                };
                ProductsLogic newProductsLogic = new ProductsLogic();
                string status = newProductsLogic.Update(oProduct);
                return Redirect("~/Products/Index");
            }
            else
            {
                return View(newProductUpdate);
            }
        }

        public ActionResult Delete(int? id)
        {
            if (Helpers.IdIsNotNull(id))
            {
                ProductsLogic newProductLogic = new ProductsLogic();
                string status = newProductLogic.Del((int)id);


                if (status.Contains("conflicted"))
                {
                    OrderDetailsLogic newOrderDetailsLogic = new OrderDetailsLogic();
                    status = newOrderDetailsLogic.DeleteProductIDFromOrder((int)id);

                    if (status.Contains("successfully"))
                    {
                        status = newProductLogic.Del((int)id);
                    }
                }
                return Content(status);
            }
            else
            {
                return View();
            }
        }
    }
}