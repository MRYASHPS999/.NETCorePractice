using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSDotNetCoreMiniProject.Models
{
    public class Manager
    {

        [Key]
        public int mgrid { get; set; }
        public string mgrname { get; set; }

        public string mgrstatus { get; set; }

        public List<Employee> emps { get; set; }


        //[ForeignKey("depts")]   //"depts" is the navigation property for mapping
        //public int deptid { get; set; }

        //public Department depts { get; set; }

        //public List<Employee> emplist { get; set; }





    }
}
