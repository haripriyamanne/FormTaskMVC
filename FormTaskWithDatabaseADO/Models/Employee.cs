using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskWithDatabaseADO.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "FirstName is mandatory")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "LastName is mandatory")]
        public string LastName { get; set; }
        //[RegularExpression("^[a-z0-9][@][g][m][a][i][l][.][c][o][m]$")]
        [Required(ErrorMessage = "Email is mandatory")]
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        [RegularExpression("^[6-9]{1}[0-9]{9}$")]
        [Required(ErrorMessage = "Phone Number is mandatory")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Gender is mandatory")]
        public Gender Gender { get; set; }
        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company Name is mandatory")]
        public string CompanyName { get; set; }
        [Display(Name = "Company Type")]
        [Required(ErrorMessage = "Company Type is mandatory")]
        public CompanyType CompanyType { get; set; }
        [Display(Name = "Company Limited")]
        [Required(ErrorMessage = "Company Limited is mandatory")]
        public string CompanyLimited { get; set; }
        [Display(Name = "Company Website")]
        [Required(ErrorMessage = "Company Website is mandatory")]
        public string CompanyWebsite { get; set; }
        [Display(Name = "Please Describe Your Business")]
        [Required(ErrorMessage = "This field is mandatory")]
        public string Busineess { get; set; }
        [Display(Name = "Please Provide 3-7 Benefits that you offers to your Customers")]
        [Required(ErrorMessage = "This field is mandatory")]
        public string Benifits { get; set; }
        [Display(Name = "Please List the Products or Services you want to showcase your HomePage")]
        [Required(ErrorMessage = "This field is mandatory")]
        public string ListProducts { get; set; }
        [Display(Name = "Add 1-3 Trust Elements")]
        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(100, MinimumLength = 3)]
        public string TrustElements { get; set; }
        [Display(Name = "List any Service areas you want to target")]
        [Required(ErrorMessage = "This field is mandatory")]
        //public List<CheckBoxModel> ServiceAreas { get; set; }
        //[Display(Name = "List Anything else you would like to mention or feel is important")]
        //[Required(ErrorMessage = "This field is mandatory")]
        public string ImportantAreas { get; set; }
        [Display(Name = "List one website example that you like and what you like about them ?")]
        [Required(ErrorMessage = "This field is mandatory")]
        public string WebsiteExample { get; set; }

    }
    public enum Gender
    {
        Male,
        Female
    }
    public enum CompanyType
    {
        Manfacturing,
        Industry,
        Software,
        NGO,
        OutSourcing
    }
}
