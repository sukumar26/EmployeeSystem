using EmployeeSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeSystem.Domain
{
    public interface IEmployeeDomain
    {
        Task<List<Employee>> GetAllEmployees();

        Task<bool> AddEmployeeAsync(Employee employee);

        Task<bool> UpdateEmployeeAsync(Employee employee);

        Task<bool> DeleteEmployeeAsync(int empId);
        Task<bool> EmployeePaymentAsync();
    }
}
