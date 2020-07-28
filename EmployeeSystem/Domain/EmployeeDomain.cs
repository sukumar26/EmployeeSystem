using EmployeeSystem.Data;
using EmployeeSystem.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeSystem.Domain.Hepler;

namespace EmployeeSystem.Domain
{
    public class EmployeeDomain
    {
        private readonly Lazy<IEmployeeRepository> employeeRepository;
        private readonly Lazy<IPaymentRepository> paymentRepository;

        public async Task<List<Employee>> GetAllEmployees()
        {
            try
            {
                return await employeeRepository.Value.GetAllEmployees().ConfigureAwait(false);
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
                MailService mailService = new MailService();
                mailService.SendMail(employee.EmailID, "Added", "Congratz.. Welcome to Accion Lab");
                return await employeeRepository.Value.AddEmployeeAsync(employee).ConfigureAwait(false);
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
                return await employeeRepository.Value.UpdateEmployeeAsync(employee).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteEmployeeAsync(int emp)
        {
            try
            {
                return await employeeRepository.Value.DeleteEmployeeAsync(emp).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> EmployeePaymentAsync()
        {
            try
            {
                var allEmp = await employeeRepository.Value.GetAllEmployees().ConfigureAwait(false);
                PaymentService paymentService = new PaymentService();
                for(int i=0;i<=allEmp.Count;i++)
                {
                    if (allEmp[i].EmployeeType == "Contractual")
                        paymentService.PayContractualEmployee();
                    else
                    {
                        double bonusAmount = await employeeRepository.Value.GetBonusAmount(allEmp[i].ID).ConfigureAwait(false);
                        paymentService.PayPermanantEmployee(bonusAmount);
                    }
                }          
               
                Payment payment = new Payment();
                Employee employee = new Employee();
                return await paymentRepository.Value.PaymentDetails(payment, employee).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
