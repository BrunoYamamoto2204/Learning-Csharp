

namespace Aula143_FixacaoInterface.cs.Services
{
    class PaypalService : IPaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double SimpleInterest(double amount, int months)
        {
            return amount * 0.01 * months;
        }

    }
}
