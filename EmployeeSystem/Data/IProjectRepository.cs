using EmployeeSystem.Models;
using System.Threading.Tasks;

namespace EmployeeSystem.Data
{
    public interface IProjectRepository
    {
        Task<bool> AssignProjectToEmployee(Project project, Employee employee);
    }
}
