using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace Objects.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Ключ", "Значение");
            return View(data);
        }
    }
}
