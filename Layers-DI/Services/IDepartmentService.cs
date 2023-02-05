using Layers_DI.ViewModels;

namespace Layers_DI.Services
{
    public interface IDepartmentService
    {
        List<DepartmentVM> GetAll();
    }
}