using CheckBoxes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheckBoxes.Models
{
    public class RegistrationModel
    {
        [Display(Name = "List any Service areas you want to target")]
        [Required(ErrorMessage = "This field is mandatory")]
        public List<CheckBoxModel> ServiceAreas { get; set; } 

    }
    //public enum ServiceAreas
    //{
    //    Cleaning,
    //    Software,
    //    UserInterface,
    //    Product,
    //    Backend
    //}

}
