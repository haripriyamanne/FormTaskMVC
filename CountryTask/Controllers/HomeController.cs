using CountryTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CountryTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Privacy()
        {
            return View();
        }
        public ActionResult Index()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem
            {
                Text = "Select Category",
                Value = "0",
                Selected = true
            });

            items.Add(new SelectListItem { Text = "India", Value = "1" });

            items.Add(new SelectListItem { Text = "US", Value = "2" });

            items.Add(new SelectListItem { Text = "UK", Value = "3" });

            items.Add(new SelectListItem { Text = "Australia", Value = "4" });

            items.Add(new SelectListItem { Text = "Canda", Value = "5" });

            items.Add(new SelectListItem { Text = "Finland", Value = "6" });

            items.Add(new SelectListItem { Text = "Germany", Value = "7" });

            items.Add(new SelectListItem { Text = "Eygpt", Value = "8" });

            ViewBag.CategoryType = items;

            return View();
        }
        public JsonResult GetSubCategories(string id)
        {
            List<SelectListItem> subCat = new List<SelectListItem>();

            subCat.Add(new SelectListItem
            {
                Text = "Select",
                Value = "0"
            });

            switch (id)
            {
                case "1":
                    subCat.Add(new SelectListItem { Text = "AP", Value = "1" });
                    subCat.Add(new SelectListItem { Text = "Telengana", Value = "2" });
                    subCat.Add(new SelectListItem { Text = "Bhiar", Value = "3" });
                    subCat.Add(new SelectListItem { Text = "Tami Nadu", Value = "4" });
                    break;
                case "2":
                    subCat.Add(new SelectListItem { Text = "Californi", Value = "1" });
                    subCat.Add(new SelectListItem { Text = "Florida", Value = "2" });
                    subCat.Add(new SelectListItem { Text = "Hawaii", Value = "3" });
                    subCat.Add(new SelectListItem { Text = "Colorado", Value = "4" });
                    break;
                case "3":
                    subCat.Add(new SelectListItem { Text = "Scotland", Value = "1" });
                    subCat.Add(new SelectListItem { Text = "Wales", Value = "2" });
                    break;
                case "4":
                    subCat.Add(new SelectListItem { Text = "Victoria", Value = "1" });
                    break;
                case "5":
                    subCat.Add(new SelectListItem { Text = "Alberta", Value = "1" });
                    subCat.Add(new SelectListItem { Text = "Manitoba", Value = "2" });
                    break;
                case "6":
                    subCat.Add(new SelectListItem { Text = "Turku", Value = "1" });
                    break;
                case "7":
                    subCat.Add(new SelectListItem { Text = "Dried Fr", Value = "1" });
                    break;
                case "8":
                    subCat.Add(new SelectListItem { Text = "Fish", Value = "1" });
                    subCat.Add(new SelectListItem { Text = "Crab", Value = "2" });
                    break;
                default:
                    subCat.Add(new SelectListItem { Text = "Select Item", Value = "1" });
                    break;
            }

            return Json(new SelectList(subCat,"Value", "Text"));
        }

    }


}

