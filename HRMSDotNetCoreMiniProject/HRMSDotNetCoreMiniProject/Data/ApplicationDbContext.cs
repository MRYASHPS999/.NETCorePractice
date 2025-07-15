using HRMSDotNetCoreMiniProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

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

        public DbSet<DocumentUpload> documents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.Entity<Employee>
            (ent =>{ 

                ent.HasOne(x => x.manager)
                .WithMany(x => x.emps)
                .HasForeignKey(x => x.mgrid)
                .OnDelete(DeleteBehavior.Restrict);

                //// Optional: One-to-many: Department → Employees
                //builder.Entity<Employee>()
                //    .HasOne(e => e.department)
                //    .WithMany(d => d.emplist)
                //    .HasForeignKey(e => e.deptid)
                //    .OnDelete(DeleteBehavior.Restrict);

                //// Optional: One-to-many: Employee → Documents
                //builder.Entity<DocumentUpload>()
                //    .HasOne(d => d.Employee)
                //    .WithMany(e => e.Documents)
                //    .HasForeignKey(d => d.EmployeeId)
                //    .OnDelete(DeleteBehavior.Cascade);

            });
        }


    }
}
