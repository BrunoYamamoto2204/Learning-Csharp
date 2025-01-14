using System;
using Aula109_Upcast_Downcast.Entities;

namespace Aula109_Upcast_Downcast
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc= new Account (1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount (1001, "Alex", 0.0, 500);

            // Upcasting 
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount (1003, "Bob", 0.0, 200);
            Account acc3 = new SavingsAccount (1004, "Anna", 0.0, 0.01);

            // Downcating
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            
        }
    }
}
