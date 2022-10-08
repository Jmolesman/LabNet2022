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
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            List<CategoriesResponse> newListOfCategories;
            CategoriesLogic newCategoriesLogic = new CategoriesLogic();

            newListOfCategories = newCategoriesLogic.GetAll().Select(c => new CategoriesResponse
            {
                CategoryID = c.CategoryID,
                CategoryName = c.CategoryName,
                Description = c.Description
            }).OrderBy(k => k.CategoryName).ToList();

            return View(newListOfCategories);
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoriesInsertUpdate newCategoryInsert)
        {
            if (ModelState.IsValid)
            {
                Categories oCategory = new Categories
                {
                    CategoryName = newCategoryInsert.CategoryName,
                    Description = newCategoryInsert.Description
                };
                CategoriesLogic newCategoriesLogic = new CategoriesLogic();
                string status = newCategoriesLogic.Add(oCategory);
                return Redirect("~/Categories/Index");
            }
            else
            {
                return View(newCategoryInsert);
            }
        }

        [HttpGet]
        public ActionResult Update(int? id)
        {
            if (Helpers.IdIsNotNull(id))
            {
                CategoriesLogic newCategoriesLogic = new CategoriesLogic();
                Categories oCategory = newCategoriesLogic.GetEntityByID((int)id);
                CategoriesInsertUpdate newCategoryUpdate = new CategoriesInsertUpdate()
                {
                    CategoryID = oCategory.CategoryID,
                    CategoryName = oCategory.CategoryName,
                    Description = oCategory.Description
                };
                return View(newCategoryUpdate);
            }
            else
            {
                return Redirect("~/Categories/Index");
            }
        }

        [HttpPost]
        public ActionResult Update(CategoriesInsertUpdate newCategoriesUpdate)
        {
            if (ModelState.IsValid)
            {
                Categories oCategory = new Categories
                {
                    CategoryID = newCategoriesUpdate.CategoryID,
                    CategoryName = newCategoriesUpdate.CategoryName,
                    Description = newCategoriesUpdate.Description
                };
                return Redirect("~/Categories/Index");
            }
            else
            {
                return View(newCategoriesUpdate);
            }
        }

        public ActionResult Delete(int? id)
        {
            if (Helpers.IdIsNotNull(id))
            {
                CategoriesLogic newCategoriesLogic = new CategoriesLogic();
                string status = newCategoriesLogic.Del((int)id);
                return Content(status);
            }
            else
            {
                return Redirect("~/Categories/Index");
            }
        }
    }
}