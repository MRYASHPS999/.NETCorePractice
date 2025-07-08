using FullStackCodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStackCodeFirstApproach.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {


        
        }

        public DbSet<Employee> emps { get; set; }


    }
}
