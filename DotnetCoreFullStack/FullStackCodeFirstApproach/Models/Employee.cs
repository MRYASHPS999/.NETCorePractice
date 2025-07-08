using System.ComponentModel.DataAnnotations;

namespace FullStackCodeFirstApproach.Models
{
    public class Employee
    {
        [Key] //data annotation for seeting primary key for table
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public double salary { get; set; }
    }
}
