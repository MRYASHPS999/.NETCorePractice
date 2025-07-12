using Microsoft.EntityFrameworkCore;

namespace HRMSDotNetCoreMiniProject.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }



    }
}
