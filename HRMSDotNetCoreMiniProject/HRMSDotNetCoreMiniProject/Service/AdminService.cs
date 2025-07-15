using HRMSDotNetCoreMiniProject.Data;
using HRMSDotNetCoreMiniProject.Models;
using HRMSDotNetCoreMiniProject.Repository;
using Microsoft.EntityFrameworkCore;

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

        //file upload section
        public void UploadDocument(IFormFile file, int empid, string uploadedBy)
        {
            if (file == null || file.Length == 0) return;

            string folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
            Directory.CreateDirectory(folder);

            string fileName = Path.GetFileName(file.FileName);
            string path = Path.Combine(folder, fileName);

            using var stream = new FileStream(path, FileMode.Create);
            file.CopyTo(stream);

            var doc = new DocumentUpload
            {
                filename = fileName,
                filepath = "/uploads/" + fileName,
                uploadedby = uploadedBy,
                uploadedon = DateTime.Now,
                empid = empid
            };

            db.documents.Add(doc);
            db.SaveChanges();
        }

        public List<DocumentUpload> GetAllDocuments()
        {
            return db.documents.Include(d => d.Employee).ToList();
        }
        //file section ends

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
