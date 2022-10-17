using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Logic;
using Lab.Ejercicio008.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;


namespace Lab.Ejercicio008.WebApi.Controllers
{
    public class SuppliersController : ApiController
    {
        //GET: /api/Suppliers
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                SuppliersLogic newLogic = new SuppliersLogic();
                List<SuppliersViewModel> listOfSuppliersViewModel = newLogic.GetAll().Select(s => new SuppliersViewModel
                {
                    SupplierID = s.SupplierID,
                    CompanyName = s.CompanyName,
                    ContactName = s.ContactName,
                    ContactTitle = s.ContactTitle
                }).ToList();

                return Ok(listOfSuppliersViewModel);
            }
            catch (NullReferenceException)
            {
                return Content(HttpStatusCode.NotFound, "Error getting list of categories");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //GET: /api/Suppliers/{id}
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                SuppliersLogic newLogic = new SuppliersLogic();
                var oSupplier = newLogic.GetEntityByID(id);

                if (oSupplier == null)
                {
                    throw new NullReferenceException();
                }

                SuppliersViewModel response = new SuppliersViewModel()
                {
                    SupplierID = oSupplier.SupplierID,
                    CompanyName = oSupplier.CompanyName,
                    ContactName = oSupplier.ContactName,
                    ContactTitle = oSupplier.ContactTitle
                };
                return Ok(response);
            }
            catch (NullReferenceException)
            {
                return Content(HttpStatusCode.NotFound, "The supplier you are looking for does not exist");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //POST: /api/Suppliers
        [HttpPost]
        public IHttpActionResult Add([FromBody] SuppliersViewModel newSupplier)
        {
            try
            {
                Suppliers oSupplier = new Suppliers()
                {
                    CompanyName = newSupplier.CompanyName,
                    ContactName = newSupplier.ContactName,
                    ContactTitle = newSupplier.ContactTitle
                };
                SuppliersLogic newLogic = new SuppliersLogic();
                string status = newLogic.Add(oSupplier);
                if (status.Contains("successfully"))
                {
                    return Content(HttpStatusCode.Created, status);
                }
                else
                {
                    return Content(HttpStatusCode.BadRequest, status);
                }
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //PUT: /api/Suppliers
        [HttpPut]
        public IHttpActionResult Update([FromBody] SuppliersViewModel supplierUpdate)
        {
            try
            {
                Suppliers oSupplier = new Suppliers()
                {
                    SupplierID = supplierUpdate.SupplierID,
                    CompanyName = supplierUpdate.CompanyName,
                    ContactName = supplierUpdate.ContactName,
                    ContactTitle = supplierUpdate.ContactTitle
                };
                SuppliersLogic newLogic = new SuppliersLogic();
                string status = newLogic.Update(oSupplier);
                if (status.Contains("successfully"))
                {
                    return Content(HttpStatusCode.OK, status);
                }
                else
                {
                    return Content(HttpStatusCode.BadRequest, status);
                }
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //POST: /api/Suppliers/{id}
        [HttpPost]
        public IHttpActionResult Del(int id)
        {
            try
            {
                SuppliersLogic newLogic = new SuppliersLogic();
                string status = newLogic.Del(id);
                if (status.Contains("successfully"))
                {
                    return Content(HttpStatusCode.OK, status);
                }
                else
                {
                    return Content(HttpStatusCode.BadRequest, status);
                }
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}