using Aula143_FixacaoInterface.cs.Entities;


namespace Aula143_FixacaoInterface.cs.Services
{
    class ContractService
    {
        // Atributos
        private IPaymentService _paymentService;

        // Construtor
        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        // Métodos
        public void processContract(Contract contract, int months)
        {
            double basicQuote = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuote + _paymentService.SimpleInterest(basicQuote, months);
                double fullQuota = updateQuota + _paymentService.PaymentFee(updateQuota);
                contract.addInstallment(new Installment(date, fullQuota));
            }
        }

    }
}
