using HRMSDotNetCoreMiniProject.Models;

namespace HRMSDotNetCoreMiniProject.Repository
{
    public interface IUserService
    {
        List<DocumentUpload> GetDocumentsForUser(int empid);
    }

}
