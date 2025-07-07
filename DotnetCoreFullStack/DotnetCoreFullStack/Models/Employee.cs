using System.ComponentModel.DataAnnotations;

namespace DotnetCoreFullStack.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Id Field is required")]
        [Display(Name = "Emp ID")]
        public int id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        [Display(Name = "Emp Name")]
        public string name { get; set; }

        [Required(ErrorMessage ="Salary is Mandatory")]
        [Display(Name = "Emp Salary")]
        public double  salary { get; set; }
    }
}
