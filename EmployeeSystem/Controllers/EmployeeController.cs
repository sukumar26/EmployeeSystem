using EmployeeSystem.Domain;
using EmployeeSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly Lazy<IEmployeeDomain> employeeDomain;

        [Route("GetAllEmp")]
        [HttpGet]
        public async Task<List<Employee>> GetAllEmpAsync()
        {
            try
            {
                List<Employee> emp = new List<Employee>();
                emp = await employeeDomain.Value.GetAllEmployees().ConfigureAwait(false);
                return emp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("AddEmployee")]
        [HttpPost]
        public async Task<bool> AddEmployeeAsync(Employee employee)
        {
            try
            {
                return await employeeDomain.Value.AddEmployeeAsync(employee).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("UpdateEmployee")]
        [HttpPut]
        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            try
            {
                return await employeeDomain.Value.UpdateEmployeeAsync(employee).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("DeleteEmployee")]
        [HttpDelete]
        public async Task<bool> DeleteEmployeeAsync(int empId)
        {
            try
            {
                return await employeeDomain.Value.DeleteEmployeeAsync(empId).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("EmployeePayment")]
        [HttpPost]
        public async Task<bool> EmployeePaymentAsync()
        {
            try
            {
                return await employeeDomain.Value.EmployeePaymentAsync().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}