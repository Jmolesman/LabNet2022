using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Logic;
using Lab.Ejercicio008.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Linq;
using Lab.Ejercicio004.EF.Utils;

namespace Lab.Ejercicio008.WebApi.Controllers
{
    public class CategoriesController : ApiController
    {
        //GET: /api/Categories/GetAll
        [HttpGet]
        public IHttpActionResult GetAll()
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
            catch (NullReferenceException)
            {
                return Content(HttpStatusCode.NotFound, "Error getting list of categories");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //GET: /api/Categories/Get/{id}
        [HttpGet]
        public IHttpActionResult Get(int id)
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
        public IHttpActionResult Add([FromBody] CategoriesViewModel newCategory)
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

        //PUT: /api/Categories/Update
        [HttpPut]
        public IHttpActionResult Update([FromBody] CategoriesViewModel categoryUpdate)
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

        //POST: /api/Categories/Del/{id}
        [HttpPost]
        public IHttpActionResult Del(int id)
        {
            try
            {
                CategoriesLogic newLogic = new CategoriesLogic();
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