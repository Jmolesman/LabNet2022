using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Logic;
using Lab.Ejercicio008.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Lab.Ejercicio008.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        //GET: /api/Products
        [HttpGet]
        public IHttpActionResult GetAllProducts()
        {
            try
            {
                ProductsLogic newProductsLogic = new ProductsLogic();
                List<ProductsViewModel> listOfProductsViewModel = newProductsLogic.GetAll().Select(p => new ProductsViewModel
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    QuantityPerUnit = p.QuantityPerUnit,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    Discontinued = p.Discontinued,
                    CategoryID = p.CategoryID,
                    SupplierID = p.SupplierID
                }).ToList();

                return Ok(listOfProductsViewModel);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //GET: /api/Products/{id}
        [HttpGet]
        public IHttpActionResult GetProduct(int id)
        {
            try
            {
                ProductsLogic newLogic = new ProductsLogic();
                var oProduct = newLogic.GetEntityByID(id);

                if (oProduct == null)
                {
                    throw new NullReferenceException();
                }

                ProductsViewModel response = new ProductsViewModel()
                {
                    ProductID = oProduct.ProductID,
                    ProductName = oProduct.ProductName,
                    QuantityPerUnit = oProduct.QuantityPerUnit,
                    UnitPrice = oProduct.UnitPrice,
                    UnitsInStock = oProduct.UnitsInStock,
                    Discontinued = oProduct.Discontinued,
                    CategoryID = oProduct.CategoryID,
                    SupplierID = oProduct.SupplierID
                };
                return Ok(response);
            }
            catch (NullReferenceException)
            {
                return Content(HttpStatusCode.NotFound, "The product you are looking for does not exist");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //POST: /api/Products
        [HttpPost]
        public IHttpActionResult AddProduct([FromBody] ProductsViewModel newProduct)
        {
            try
            {
                Products oProduct = new Products()
                {
                    ProductName = newProduct.ProductName,
                    QuantityPerUnit = newProduct.QuantityPerUnit,
                    UnitPrice = newProduct.UnitPrice,
                    UnitsInStock = newProduct.UnitsInStock,
                    Discontinued = newProduct.Discontinued,
                    CategoryID = newProduct.CategoryID,
                    SupplierID = newProduct.SupplierID
                };
                ProductsLogic newLogic = new ProductsLogic();
                string status = newLogic.Add(oProduct);
                if (status.Contains("Error"))
                {
                    return Content(HttpStatusCode.BadRequest, "There are errors in the data provided");
                }
                return Content(HttpStatusCode.Created, oProduct);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //PUT: /api/Products/
        [HttpPut]
        public IHttpActionResult EditProduct([FromBody] ProductsViewModel productUpdate)
        {
            try
            {
                Products oProduct = new Products()
                {
                    ProductID = productUpdate.ProductID,
                    ProductName = productUpdate.ProductName,
                    QuantityPerUnit = productUpdate.QuantityPerUnit,
                    UnitPrice = productUpdate.UnitPrice,
                    UnitsInStock = productUpdate.UnitsInStock,
                    Discontinued = productUpdate.Discontinued,
                    CategoryID = productUpdate.CategoryID,
                    SupplierID = productUpdate.SupplierID
                };
                ProductsLogic newLogic = new ProductsLogic();
                string status = newLogic.Update(oProduct);
                if (status.Contains("Error"))
                {
                    return Content(HttpStatusCode.BadRequest, "There are errors in the data provided");
                }
                return Content(HttpStatusCode.Created, oProduct);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //POST: /api/Products/{id}
        [HttpPost]
        public IHttpActionResult DelProducts(int id)
        {
            try
            {
                ProductsLogic newLogic = new ProductsLogic();
                string status = newLogic.Del(id);
                if (status.Contains("Error"))
                {
                    return Content(HttpStatusCode.BadRequest, $"The product you want to delete does not exist {id}");
                }
                if (status.Contains("conflicted"))
                {
                    return Content(HttpStatusCode.BadRequest, $"The product you want to delete is related to another table");
                }
                return Content(HttpStatusCode.OK, $"Deleted product with ID: {id}");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}