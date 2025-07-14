using HRMSDotNetCoreMiniProject.Data;
using HRMSDotNetCoreMiniProject.Models;
using HRMSDotNetCoreMiniProject.Repository;

namespace HRMSDotNetCoreMiniProject.Service
{
    public class AdminService : IAdminService
    {
        ApplicationDbContext db;
        public AdminService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void AddEmp(Employee e)
        {
            db.employees.Add(e);
            db.SaveChanges();
        }

        public List<Employee> displayEmp()
        {
            var data = db.employees.ToList();
            return data;
        }

        public void DeleteEmp(int id)
        {
            var d = db.employees.Find(id);
            db.employees.Remove(d);
            db.SaveChanges();
        }

        public Employee findEmpById(int id)
        {
            var data = db.employees.Find(id);
            return data;
        }

        public void UpdateEmpDetails(Employee e)
        {
            db.employees.Update(e);
            db.SaveChanges();
        }

        public void AddMgr(Manager mgr)
        {
            db.managers.Add(mgr);
            db.SaveChanges();
        }

        public void AddDept(Department dept)
        {
            db.departments.Add(dept);
            db.SaveChanges();
        }







    }



}
