using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskMVC.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Name is mandatory")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Name is mandatory")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is mandatory")]
        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public string Gender { get; set; }

        public string CompanyName { get; set; }
    }
}
