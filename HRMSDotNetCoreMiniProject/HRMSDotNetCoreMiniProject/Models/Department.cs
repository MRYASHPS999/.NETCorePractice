using System.ComponentModel.DataAnnotations;

namespace HRMSDotNetCoreMiniProject.Models
{
    public class Department
    {
        [Key]
        public int deptid { get; set; }

        public string deptname { get; set; }

        public string deptstatus { get; set; }


        public List<Employee> emplist { get; set; }


    }
}
