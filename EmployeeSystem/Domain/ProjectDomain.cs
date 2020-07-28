using EmployeeSystem.Data;
using EmployeeSystem.Models;
using System;
using System.Threading.Tasks;

namespace EmployeeSystem.Domain
{
    public class ProjectDomain
    {
        private readonly Lazy<IProjectRepository> projectRepository;
        public async Task<bool> AssignProjectToEmployee(Project project, Employee employee)
        {
            try
            {
                await projectRepository.Value.AssignProjectToEmployee(project, employee);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
