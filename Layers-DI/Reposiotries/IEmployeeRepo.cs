using Layers_DI.Models;

namespace Layers_DI.Reposiotries
{
    public interface IEmployeeRepo
    {
        int Add(Employee employee);
        int Delete(int id);
        int Edit(Employee employee);
        List<Employee> GetAll();
        Employee GetById(int id);
    }
}