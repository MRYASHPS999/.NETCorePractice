using HRMSDotNetCoreMiniProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMSDotNetCoreMiniProject.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> employees { get; set; }

        public DbSet<Manager> managers { get; set; }

        public DbSet<Department> departments { get; set; }

        public DbSet<UserDetails> userdetails { get; set; }


    }
}
