using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    internal class StripeAdapter: IPaymentProcessor
    {
        public readonly StripePayment _stripePayment;

        public StripeAdapter(StripePayment stripePayment)
        { 
            _stripePayment = stripePayment;
        }

        public void Pay(decimal amount)
        {
            _stripePayment.MakeStripePayment(amount);
        }
    }
}
