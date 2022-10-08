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
        // GET: Suppliers
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
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(SuppliersInsertUpdate newSuppliersInsert)
        {
            if (ModelState.IsValid)
            {
                Suppliers oSupplier = new Suppliers
                {
                    CompanyName = newSuppliersInsert.CompanyName,
                    ContactName = newSuppliersInsert.ContactName,
                    ContactTitle = newSuppliersInsert.ContactTitle
                };
                SuppliersLogic newSuppliersLogic = new SuppliersLogic();
                string status = newSuppliersLogic.Add(oSupplier);
                return Redirect("~/Suppliers/Index");
            }
            else
            {
                return View(newSuppliersInsert);
            }
        }

        [HttpGet]
        public ActionResult Update(int? id)
        {
            if (Helpers.IdIsNotNull(id))
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
                return Redirect("~/Suppliers/Index");
            }
        }

        [HttpPost]
        public ActionResult Update(SuppliersInsertUpdate newSupplierUpdate)
        {
            if (ModelState.IsValid)
            {
                Suppliers oSupplier = new Suppliers
                {
                    SupplierID = newSupplierUpdate.SupplierID,
                    CompanyName = newSupplierUpdate.CompanyName,
                    ContactName = newSupplierUpdate.ContactName,
                    ContactTitle = newSupplierUpdate.ContactTitle
                };
                SuppliersLogic newSuppliersLogic = new SuppliersLogic();
                string status = newSuppliersLogic.Update(oSupplier);

                return Redirect("~/Suppliers/Index");
            }
            else
            {
                return View(newSupplierUpdate);
            }
        }

        public ActionResult Delete(int? id)
        {
            if (Helpers.IdIsNotNull(id))
            {
                SuppliersLogic newSuppliersLogic = new SuppliersLogic();
                string status = newSuppliersLogic.Del((int)id);
                return Content(status);
            }
            else
            {
                return Redirect("~/Suppliers/Index");
            }
        }
    }
}