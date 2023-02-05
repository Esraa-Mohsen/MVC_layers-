using Layers_DI.Models;

namespace Layers_DI.Reposiotries
{
    public interface IDepartmentRepo
    {
        List<Department> GetAll();
    }
}