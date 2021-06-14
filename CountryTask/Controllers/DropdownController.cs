using CountryTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryTask.Controllers
{
    public class DropdownController : Controller
    {
        public IActionResult Index()
        {
            List<SelectListItem> state = new List<SelectListItem>();
            state.Add(new SelectListItem { Text = "Bihar", Value = "Bihar" });
            state.Add(new SelectListItem { Text = "Jharkhand", Value = "Jharkhand" });
            ViewBag.StateName = new SelectList(state, "Value", "Text");
            return View();
        }
        public JsonResult DistrictList(string Id)
        {
            var district = from s in District.GetDistrict()
                           where s.StateName == Id
                           select s;

            return Json(new SelectList(district.ToArray(), "StateName", "DistrictName"));
        }
        [HttpPost]
        public ActionResult Index(ApplicationModel formdata)
        {
           
            if (formdata.State == null)
            {
                ModelState.AddModelError("State", "State is required field.");
            }
            if (formdata.District == null)
            {
                ModelState.AddModelError("District", "District is required field.");
            }

            if (!ModelState.IsValid)
            {
                //Populate the list again
                List<SelectListItem> state = new List<SelectListItem>();
                state.Add(new SelectListItem { Text = "Bihar", Value = "Bihar" });
                state.Add(new SelectListItem { Text = "Jharkhand", Value = "Jharkhand" });
                ViewBag.StateName = new SelectList(state, "Value", "Text");

                return View("Index");
            }

            //TODO: Database Insertion

            return RedirectToAction("Index", "Home");
        }
    }
}
