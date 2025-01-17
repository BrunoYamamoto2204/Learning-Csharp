

namespace Aula143_FixacaoInterface.cs.Services
{
    interface IPaymentService
    {
        double PaymentFee(double amount);
        double SimpleInterest (double amount, int months);
    }
}
