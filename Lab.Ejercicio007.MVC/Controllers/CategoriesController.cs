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
        [HttpGet]
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
        public ActionResult InsertOrUpdate(int? id)
        {
            if (Helpers.IdIsNotNullOrZero(id))
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
                return View(new CategoriesInsertUpdate());
            }
        }

        [HttpPost]
        public ActionResult InsertOrUpdate(CategoriesInsertUpdate newCategory)
        {
            if (Helpers.IdIsNotNullOrZero(newCategory.CategoryID))
            {
                if (ModelState.IsValid)
                {
                    Categories oCategory = new Categories
                    {
                        CategoryID = newCategory.CategoryID,
                        CategoryName = newCategory.CategoryName,
                        Description = newCategory.Description
                    };
                    CategoriesLogic newCategoriesLogic = new CategoriesLogic();
                    string status = newCategoriesLogic.Update(oCategory);
                    return Redirect("~/Categories/Index");
                }
                else
                {
                    return View(newCategory);
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    Categories oCategory = new Categories
                    {
                        CategoryName = newCategory.CategoryName,
                        Description = newCategory.Description
                    };
                    CategoriesLogic newCategoriesLogic = new CategoriesLogic();
                    string status = newCategoriesLogic.Add(oCategory);
                    return Redirect("~/Categories/Index");
                }
                else
                {
                    return View(newCategory);
                }
            }
        }

        public ActionResult Delete(int? id)
        {
            if (Helpers.IdIsNotNullOrZero(id))
            {
                CategoriesLogic newCategoriesLogic = new CategoriesLogic();
                string status = newCategoriesLogic.Del((int)id);

                if (status.Contains("conflicted"))
                {
                    ProductsLogic productLogic = new ProductsLogic();
                    status = productLogic.SetCategoryToNull((int)id);

                    if (status.Contains("successfully"))
                    {
                        status = newCategoriesLogic.Del((int)id);
                    }
                }
                return Content(status);
            }
            else
            {
                return Redirect("~/Categories/Index");
            }
        }
    }
}