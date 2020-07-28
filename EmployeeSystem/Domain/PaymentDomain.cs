using EmployeeSystem.Data;
using EmployeeSystem.Models;
using System;
using System.Threading.Tasks;

namespace EmployeeSystem.Domain
{
    public class PaymentDomain
    {
        private readonly Lazy<IPaymentRepository> paymentRepository;

        public async Task<bool> PaymentDetails(Payment payment, Employee employee)
        {
            try
            {
                return await paymentRepository.Value.PaymentDetails(payment,employee).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
