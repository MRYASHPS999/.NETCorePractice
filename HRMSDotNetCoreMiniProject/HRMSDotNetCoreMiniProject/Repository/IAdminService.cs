using HRMSDotNetCoreMiniProject.Models;

namespace HRMSDotNetCoreMiniProject.Repository
{
    public interface IAdminService
    {
        void AddEmp(Employee e);
        List<Employee> displayEmp();
        void DeleteEmp(int id);

        Employee findEmpById(int id);

        void AddMgr(Manager mgr);

        void AddDept(Department dept);

        void UpdateEmpDetails(Employee e);


    }


}
