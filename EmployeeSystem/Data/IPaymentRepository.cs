using EmployeeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSystem.Data
{
    public interface IPaymentRepository
    {
        Task<bool> PaymentDetails(Payment payment, Employee employee);
    }
}
