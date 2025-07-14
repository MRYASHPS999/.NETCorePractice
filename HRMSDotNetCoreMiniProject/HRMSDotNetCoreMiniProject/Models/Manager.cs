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

        public Department dept { get; set; }

        




    }
}
