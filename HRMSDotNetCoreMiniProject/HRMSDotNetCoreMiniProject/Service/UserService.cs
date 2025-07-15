using HRMSDotNetCoreMiniProject.Data;
using HRMSDotNetCoreMiniProject.Models;
using HRMSDotNetCoreMiniProject.Repository;

namespace HRMSDotNetCoreMiniProject.Service
{
    public class UserService : IUserService
    {
        ApplicationDbContext db;
        public UserService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<DocumentUpload> GetDocumentsForUser(int empid)
        {
            return db.documents.Where(d => d.empid == empid).ToList();
        }

    }



}
