using EmployeeSystem.Domain;
using EmployeeSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EmployeeSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly Lazy<IProjectDomain> projectDomain;

        [Route("AssignProject")]
        [HttpPost]
        public async Task<bool> AssignProjectToEmployee(Project project, Employee employee)
        {
            try
            {
                return await projectDomain.Value.AssignProjectToEmployee(project, employee).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}