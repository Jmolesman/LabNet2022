using Lab.Ejercicio004.EF.Entities;
using Lab.Ejercicio004.EF.Logic;
using Lab.Ejercicio004.EF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Ejercicio007.MVC.Controllers
{
    public class OrderDetailsController : Controller
    {
        public ActionResult SetToNullOrderDetails(int id)
        {
            if (Helpers.IdIsNotNull(id))
            {
                OrderDetailsLogic newOrderDetailsLogic = new OrderDetailsLogic();
                string status = newOrderDetailsLogic.DeleteProductIDFromOrder((int)id);
                return Content(status);
            }
            else
            {
                return Redirect("~/Products/Index");
            }
        }
    }
}