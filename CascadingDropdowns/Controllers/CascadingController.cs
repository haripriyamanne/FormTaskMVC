using CascadingDropdowns.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace CascadingDropdowns.Controllers
{
    public class CascadingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetCountry()
        {
            List<Country> mod = new List<Country>
            {
                new Country{Id=1,Name="India"},
                new Country{Id=2,Name="US"}
            };

            return Json(mod, new Newtonsoft.Json.JsonSerializerSettings());
        }
        public JsonResult GetState(int CountryId)
        {
            List<State> mod = new List<State>
            {
                new State{Id=1,Name="AP",CountryId=1},
                new State{Id=2,Name="TS",CountryId=1},
                 new State{Id=3,Name="New Jersy",CountryId=2},
                new State{Id=4,Name="Florida",CountryId=2}
            };
            List<State> newList = mod.Where(a => a.CountryId == CountryId).ToList();

            return Json(newList, new Newtonsoft.Json.JsonSerializerSettings());
        }
    }
}
