using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DotnetCoreFullStack.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Id Field is required")]
        [Display(Name = "Emp ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [Display(Name = "Emp Name")]
        [StringLength (maximumLength:10 , MinimumLength =5,ErrorMessage ="Enter chaarcter between 5-10")]
        [RegularExpression("^[a-zA-Z]*$",ErrorMessage ="Name should contain only characters")]
        public string name { get; set; }

        [Display(Name = "Emp Age")]
        [Required(ErrorMessage = "Age Field is required")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Age should contain only Numbers")]
        [Range(10,50,ErrorMessage ="Age Should be In Between 10-50")]
        public int age { get; set; }

        [Required(ErrorMessage ="Salary is Mandatory")]
        [Display(Name = "Emp Salary")]
        public double  salary { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address!!!")]
        public string Email { get; set; }


        [Display(Name = "Emp PAN Number")]
        [RegularExpression("[A-Z]{5}[0-9]{4}[A-Z]{1}", ErrorMessage = "Invalid PAN Number")]
        public string panno { get; set; }

        
        public string pwd { get; set; }

        [Compare("pwd",ErrorMessage ="Password Does Not Match!!!")]
        public string confirmpwd { get; set; }


    }
}
