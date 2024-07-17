using System;
using System.Collections.Generic;
using System.Linq;

namespace RentalApplication.Payment
{
    public interface IPaymentMethod
    {
        void ProcessPayment(double amount);
    }
}
