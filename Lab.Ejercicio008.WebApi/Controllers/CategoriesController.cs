using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Logic;
using Lab.Ejercicio008.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Linq;

namespace Lab.Ejercicio008.WebApi.Controllers
{
    public class CategoriesController : ApiController
    {
        //GET: /api/Categories
        [HttpGet]
        public IHttpActionResult GetAllCategories()
        {
            try
            {
                CategoriesLogic newCategoriesLogic = new CategoriesLogic();
                List<CategoriesViewModel> listOfCategoriesViewModel = newCategoriesLogic.GetAll().Select(c => new CategoriesViewModel
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    Description = c.Description
                }).ToList();

                return Ok(listOfCategoriesViewModel);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //GET: /api/Categories/{id}
        [HttpGet]
        public IHttpActionResult GetCategory(int id)
        {
            try
            {
                CategoriesLogic newLogic = new CategoriesLogic();
                var category = newLogic.GetEntityByID(id);

                if (category == null)
                {
                    throw new NullReferenceException();
                }
                
                CategoriesViewModel response = new CategoriesViewModel()
                {
                    CategoryID = category.CategoryID,
                    CategoryName = category.CategoryName,
                    Description = category.Description
                };
                return Ok(response);
            }
            catch (NullReferenceException)
            {
                return Content(HttpStatusCode.NotFound, "The category you are looking for does not exist");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //POST: /api/Categories/Add/
        [HttpPost]
        public IHttpActionResult AddCategory([FromBody] CategoriesViewModel newCategory)
        {
            try
            {
                Categories oCategory = new Categories()
                {
                    CategoryName = newCategory.CategoryName,
                    Description = newCategory.Description,
                };
                CategoriesLogic newLogic = new CategoriesLogic();
                string status = newLogic.Add(oCategory);
                if (status.Contains("Error"))
                {
                    return Content(HttpStatusCode.BadRequest, "There are errors in the data provided");
                }
                return Content(HttpStatusCode.Created, oCategory);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //PUT: /api/Categories/
        [HttpPut]
        public IHttpActionResult EditCategory([FromBody] CategoriesViewModel categoryUpdate)
        {
            try
            {
                Categories oCategory = new Categories()
                {
                    CategoryID = categoryUpdate.CategoryID,
                    CategoryName = categoryUpdate.CategoryName,
                    Description = categoryUpdate.Description,
                };
                CategoriesLogic newLogic = new CategoriesLogic();
                string status = newLogic.Update(oCategory);
                if (status.Contains("Error"))
                {
                    return Content(HttpStatusCode.BadRequest, "There are errors in the data provided");
                }
                return Content(HttpStatusCode.Created, oCategory);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //POST: /api/Categories/Del/{id}
        [HttpPost]
        public IHttpActionResult DelCategory(int id)
        {
            try
            {
                CategoriesLogic newLogic = new CategoriesLogic();
                string status = newLogic.Del(id);
                if (status.Contains("Error"))
                {
                    return Content(HttpStatusCode.BadRequest, $"The category you want to delete does not exist {id}");
                }
                if (status.Contains("conflicted"))
                {
                    return Content(HttpStatusCode.BadRequest, $"The category you want to delete is related to another table");
                }
                return Content(HttpStatusCode.OK, $"Deleted category with ID: {id}");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}