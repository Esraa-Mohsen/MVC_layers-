using Layers_DI.Models;

namespace Layers_DI.Reposiotries
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly CompanyDBContext DB;

        public DepartmentRepo(CompanyDBContext DB)
        {
            this.DB = DB;
        }

        public List<Department> GetAll()
        {
            return DB.Departments.ToList();
        }


    }
}
