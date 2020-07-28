using EmployeeSystem.Models;
using System;
using System.Threading.Tasks;

namespace EmployeeSystem.Data
{
    public class PaymentRepository
    {
        public async Task<bool> PaymentDetails(Project project, Employee employee)
        {
            try
            {
                //SqlStatements save payment Details in DB
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
