using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSDotNetCoreMiniProject.Models
{
    public class Employee
    {

        [Key]
        public int empid { get; set; } 

        public string? empname { get; set; }

        public string? empemail { get; set; }

        public string? empsalary { get; set; }

        public string empstatus { get; set; }


        //Mapping for manager to employee
        [ForeignKey("manager")]  //"manager" is the navigation property for mapping
        public int mgrid { get; set; }
        public Manager manager { get; set; }


        //mapping for department to employee
        [ForeignKey("department")]   //"department" is the navigation property for mapping
        public int deptid { get; set; }

        public Department department { get; set; }


    }
}
