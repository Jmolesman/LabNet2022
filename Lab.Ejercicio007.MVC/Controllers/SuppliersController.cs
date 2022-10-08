using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Logic;
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

            newListOfSuppliers = newSuppliersLogic.GetAll().Select(p => new SuppliersResponse
            {
                SupplierID = p.SupplierID,
                CompanyName = p.CompanyName,
                ContactName = p.ContactName,
                ContactTitle = p.ContactTitle
            }).OrderBy(k => k.CompanyName).ToList();
            return View(newListOfSuppliers);
        }

        [HttpPost]
        public ActionResult Insert(SuppliersResponse newSuppliersResponse)
        {
            Suppliers oSupplier = new Suppliers
            {
                SupplierID = newSuppliersResponse.SupplierID,
                CompanyName = newSuppliersResponse.CompanyName,
                ContactName = newSuppliersResponse.ContactName,
                ContactTitle = newSuppliersResponse.ContactTitle
            };
            SuppliersLogic newSuppliersLogic = new SuppliersLogic();
            newSuppliersLogic.Add(oSupplier);
            return RedirectToAction("Index");
        }

        [HttpPatch]
        public ActionResult Update(SuppliersResponse newSupplierResponse)
        {
            Suppliers oSupplier = new Suppliers
            {
                SupplierID = newSupplierResponse.SupplierID,
                CompanyName = newSupplierResponse.CompanyName,
                ContactName = newSupplierResponse.ContactName,
                ContactTitle = newSupplierResponse.ContactTitle
            };
            SuppliersLogic newSuppliersLogic = new SuppliersLogic();
            newSuppliersLogic.Update(oSupplier);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            SuppliersLogic newSuppliersLogic = new SuppliersLogic();
            newSuppliersLogic.Del(id);
            return RedirectToAction("Index");
        }
    }
}