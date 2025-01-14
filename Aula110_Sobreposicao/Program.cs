﻿using System;
using Aula110_Aula110_Sobreposicao.Entities;

namespace Aula109_Upcast_Downcast
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account (1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount (1001, "Alex", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            System.Console.WriteLine(acc1.Balance);
            System.Console.WriteLine(acc2.Balance);
        }
    }
}
