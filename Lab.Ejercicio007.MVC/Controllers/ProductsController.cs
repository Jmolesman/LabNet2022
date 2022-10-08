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
        [HttpGet]
        public ActionResult Index()
        {

            List<ProductsResponse> newListOfProducts;
            ProductsLogic newProductLogic = new ProductsLogic();

            newListOfProducts= newProductLogic.GetAll().Select(p => new ProductsResponse
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                QuantityPerUnit = p.QuantityPerUnit,
                UnitPrice = p.UnitPrice,
                UnitsInStock = p.UnitsInStock,
                Discontinued = p.Discontinued
            }).OrderBy(k => k.ProductName).ToList();

            return View(newListOfProducts);
        }

        [HttpGet]
        public ActionResult InsertOrUpdate(int? id)
        {
            CategoriesLogic newcategoriesLogic = new CategoriesLogic();
            SuppliersLogic newSuppliersLogic = new SuppliersLogic();
            ProductsLogic newProductsLogic = new ProductsLogic();

            if (Helpers.IdIsNotNullOrZero(id))
            {

                Products oProduct = newProductsLogic.GetEntityByID((int)id);

                ProductsInsertUpdate newProductUpdate = new ProductsInsertUpdate();

                newProductUpdate.ProductID = oProduct.ProductID;
                newProductUpdate.ProductName = oProduct.ProductName;
                newProductUpdate.QuantityPerUnit = oProduct.QuantityPerUnit;
                newProductUpdate.UnitPrice = oProduct.UnitPrice;
                newProductUpdate.UnitsInStock = oProduct.UnitsInStock;
                newProductUpdate.Discontinued = oProduct.Discontinued;

                return View(newProductUpdate);
            }
            else
            {
                ProductsInsertUpdate newProductInsert = new ProductsInsertUpdate();
                return View(newProductInsert);
            }
        }

        [HttpPost]
        public ActionResult InsertOrUpdate(ProductsInsertUpdate newProduct)
        {
            if (Helpers.IdIsNotNullOrZero(newProduct.ProductID))
            {
                if (ModelState.IsValid)
                {
                    Products oProduct = new Products
                    {
                        ProductID = newProduct.ProductID,
                        ProductName = newProduct.ProductName,
                        QuantityPerUnit = newProduct.QuantityPerUnit,
                        UnitPrice = newProduct.UnitPrice,
                        UnitsInStock = newProduct.UnitsInStock,
                        Discontinued = newProduct.Discontinued
                    };
                    ProductsLogic newProductsLogic = new ProductsLogic();
                    string status = newProductsLogic.Update(oProduct);
                    return Redirect("~/Products/Index");
                }
                else
                {
                    return View(newProduct);
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    Products oProduct = new Products
                    {
                        ProductName = newProduct.ProductName,
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
        }

        public ActionResult Delete(int? id)
        {
            if (Helpers.IdIsNotNullOrZero(id))
            {
                ProductsLogic newProductLogic = new ProductsLogic();
                string status = newProductLogic.Del((int)id);
                return Content(status);
            }
            else
            {
                return View();
            }
        }
    }
}