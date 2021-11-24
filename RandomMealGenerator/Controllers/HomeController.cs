using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RandomMealGenerator.Models;

namespace RandomMealGenerator.Controllers
{
    public class HomeController : Controller
    {

        static WebClient client = new WebClient();
        public JObject GetProducts()
        {

            var json = client.DownloadString("https://www.themealdb.com/api/json/v1/1/random.php");
            dynamic ans = JObject.Parse(json);
            return ans;

        }

        public IActionResult Index()
        {
            var products = GetProducts();
            ViewBag.products = products;

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
