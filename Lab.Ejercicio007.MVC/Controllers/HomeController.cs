using Lab.Ejercicio007.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.Ejercicio007.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            string url = "https://quotable.io/random";
            ViewBag.Title = "Home Page";
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            var newHttpClient = new HttpClient();
            
            var json = await newHttpClient.GetStringAsync(url);
            QuoteFetch randomQuote = JsonConvert.DeserializeObject<QuoteFetch>(json);
            return View(randomQuote);
        }
    }
}