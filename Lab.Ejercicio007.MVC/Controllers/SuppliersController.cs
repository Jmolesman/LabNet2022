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
    public class SuppliersController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<SuppliersResponse> newListOfSuppliers;
            SuppliersLogic newSuppliersLogic = new SuppliersLogic();

            newListOfSuppliers = newSuppliersLogic.GetAll().Select(s => new SuppliersResponse
            {
                SupplierID = s.SupplierID,
                CompanyName = s.CompanyName,
                ContactName = s.ContactName,
                ContactTitle = s.ContactTitle
            }).OrderBy(k => k.CompanyName).ToList();

            return View(newListOfSuppliers);
        }

        [HttpGet]
        public ActionResult InsertOrUpdate(int? id)
        {
            if (Helpers.IdIsNotNullOrZero(id))
            {
                SuppliersLogic newSuppliersLogic = new SuppliersLogic();
                Suppliers oSupplier = newSuppliersLogic.GetEntityByID((int)id);

                SuppliersInsertUpdate newSupplierUpdate = new SuppliersInsertUpdate
                {
                    SupplierID = oSupplier.SupplierID,
                    CompanyName = oSupplier.CompanyName,
                    ContactName = oSupplier.ContactName,
                    ContactTitle = oSupplier.ContactTitle
                };

                return View(newSupplierUpdate);
            }
            else
            {
                return View(new SuppliersInsertUpdate());
            }
        }

        [HttpPost]
        public ActionResult InsertOrUpdate(SuppliersInsertUpdate newSupplier)
        {
            if (Helpers.IdIsNotNullOrZero(newSupplier.SupplierID))
            {
                if (ModelState.IsValid)
                {
                    Suppliers oSupplier = new Suppliers
                    {
                        SupplierID = newSupplier.SupplierID,
                        CompanyName = newSupplier.CompanyName,
                        ContactName = newSupplier.ContactName,
                        ContactTitle = newSupplier.ContactTitle
                    };
                    SuppliersLogic newSuppliersLogic = new SuppliersLogic();
                    string status = newSuppliersLogic.Update(oSupplier);

                    return Redirect("~/Suppliers/Index");
                }
                else
                {
                    return View(newSupplier);
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    Suppliers oSupplier = new Suppliers
                    {
                        CompanyName = newSupplier.CompanyName,
                        ContactName = newSupplier.ContactName,
                        ContactTitle = newSupplier.ContactTitle
                    };
                    SuppliersLogic newSuppliersLogic = new SuppliersLogic();
                    string status = newSuppliersLogic.Add(oSupplier);
                    return Redirect("~/Suppliers/Index");
                }
                else
                {
                    return View(newSupplier);
                }
            }
        }

        public ActionResult Delete(int? id)
        {
            if (Helpers.IdIsNotNullOrZero(id))
            {
                SuppliersLogic newSuppliersLogic = new SuppliersLogic();
                string status = newSuppliersLogic.Del((int)id);

                if (status.Contains("conflicted"))
                {
                    ProductsLogic productLogic = new ProductsLogic();
                    status = productLogic.SetSupplierToNull((int)id);

                    if (status.Contains("successfully"))
                    {
                        status = newSuppliersLogic.Del((int)id);
                    }
                }
                return Content(status);
            }
            else
            {
                return Redirect("~/Suppliers/Index");
            }
        }
    }
}