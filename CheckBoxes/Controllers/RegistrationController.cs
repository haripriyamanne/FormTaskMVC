using CheckBoxes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxes.Controllers
{
    public class RegistrationController : Controller
    {

        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();
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

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult RegistrationForm([Bind] RegistrationModel employee)
        {
            if (ModelState.IsValid)
            {
                objemployee.AddEmployee(employee);
                return RedirectToAction("Confirm");
            }
            return View(employee);
        }

        public IActionResult Confirm()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            RegistrationModel employee = objemployee.GetEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

    }
}
