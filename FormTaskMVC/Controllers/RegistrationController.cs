using FormTaskMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskMVC.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult RegistrationForm()
        {
            List<CheckBoxModel> ChkItem = new List<CheckBoxModel>()
        {
          new CheckBoxModel {Value=1,Text="Software",IsChecked=false },
          new CheckBoxModel {Value=1,Text="UI Developer",IsChecked=false },
          new CheckBoxModel {Value=1,Text="BackEnd Developer",IsChecked=false },
          new CheckBoxModel {Value=1,Text="Admin" ,IsChecked=false},
          new CheckBoxModel {Value=1,Text="HR Services",IsChecked=false },
          new CheckBoxModel {Value=1,Text="Full Stack Services" ,IsChecked=false},
        };
            //assigning records to the CheckBoxItems list     
            RegistrationModel ChkItems = new RegistrationModel();
            ChkItems.ServiceAreas = ChkItem;
            return View(ChkItems);
        }
        public IActionResult SaveRegistrations()
        {
            var model = new RegistrationModel()
            {
                FirstName = Request.Form["FirstName"],
                LastName = Request.Form["LastName"],
                Email = Request.Form["Email"],
                CompanyName = Request.Form["CompanyName"],
                CompanyWebsite = Request.Form["CompanyWebsite"],
                Busineess=Request.Form["Business"],
                Benifits = Request.Form["Benifits"],
                ListProducts=Request.Form["ListProducts"],
                TrustElements=Request.Form["TrustElements"],
                ImportantAreas=Request.Form["ImportantAreas"],
                WebsiteExample=Request.Form["WebsiteExample"]

        //Gender = Request.
        //PhoneNumber= Convert.ToInt32(Request.Form["PhoneNumber"])
    };  
            return View(model);
        }

        //public string SaveRegistrations(RegistrationModel registration)
        //{
        //    string fname = registration.FirstName;
        //    return fname;
        //}
       
    }
}
