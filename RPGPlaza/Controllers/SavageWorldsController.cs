using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RPGPlaza.Controllers
{
    public class SavageWorldsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}