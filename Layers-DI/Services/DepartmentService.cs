
using Layers_DI.Reposiotries;
using Layers_DI.Models;
using Layers_DI.ViewModels;
namespace Layers_DI.Services
{
    public class DepartmentService :IDepartmentService
    {
        private readonly IDepartmentRepo departmentRepo;

        public DepartmentService(IDepartmentRepo departmentRepo)
        {
            this.departmentRepo = departmentRepo;
        }

        public List<DepartmentVM> GetAll()
        {
            List<Department> departments = departmentRepo.GetAll();
            List<DepartmentVM> departmentVMs = new List<DepartmentVM>();

            foreach (var dept in departments)
            {
                departmentVMs.Add(new DepartmentVM()
                {
                    Number = dept.Number,
                    Name = dept.Name,
                    mngrSSN = dept.mngrSSN
                });
            }
            return departmentVMs;
        }
    }
}
