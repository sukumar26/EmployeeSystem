using EmployeeSystem.Models;
using System.Threading.Tasks;

namespace EmployeeSystem.Domain
{
    public interface IProjectDomain
    {
        Task<bool> AssignProjectToEmployee(Project project, Employee employee);
    }
}
