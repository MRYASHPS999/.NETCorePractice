using System.ComponentModel.DataAnnotations;

namespace FullStackCoreAppCodeFirstApproach.Models
{
    public class Employee
    {
        [Key] //data annotation for seeting primary key for table
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter Name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Email:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Salary:")]
        public double salary { get; set; }
    }


}
