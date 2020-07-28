using EmployeeSystem.Models;
using System;
using System.Threading.Tasks;

namespace EmployeeSystem.Data
{
    public class ProjectRepository
    {
        public async Task<bool> AssignProjectToEmployee(Project project, Employee employee)
        {
            try
            {
                //SqlStatements assign project to employee
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
