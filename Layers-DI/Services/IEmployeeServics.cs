using Layers_DI.ViewModels;

namespace Layers_DI.Services
{
    public interface IEmployeeServics
    {
        int Add(EmployeeVM employeeVM);
        int Delete(int id);
        int Edit(EmployeeVM employeeVM);
        List<EmployeeVM> GetAll();
        EmployeeVM GetById(int id);
    }
}