using EmployeeSystem.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeSystem.Data
{
    public class EmployeeRepository
    {
        public async Task<List<Employee>> GetAllEmployees()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                //SqlStatements
                return employees;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> AddEmployeeAsync(Employee employee)
        {
            try
            {
                //SqlStatements
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            try
            {
                //SqlStatements
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> DeleteEmployeeAsync(int empId)
        {
            try
            {
                //SqlStatements
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<double> GetBonusAmount(int empId)
        {
            try
            {
                //SqlStatements
                return 12345.00;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
