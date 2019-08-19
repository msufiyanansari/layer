using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Saioncorp.Models;

namespace Saioncorp.Controllers
{
	public class HomeController : Controller
	{
        private DataContext db = new DataContext();
		public IActionResult Index()
		{
            ViewBag.Products = db.Products.ToList();
            ViewBag.Promotions = db.Promotions.ToList();
            return View();
		}

	}
}
