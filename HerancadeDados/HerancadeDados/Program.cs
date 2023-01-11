using System;
using HerancadeDados.Entities;

class Curse
{

    static void Main(string[] args)
    {

        Account acc1 = new Account(1001, "Alex", 500.0);
        Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
        Account acc3 = new BusinessAccount(1003, "Joao", 500.0, 20.0);

        acc1.WithDraw(10.0);
        acc2.WithDraw(10.0);
        acc3.WithDraw(10.0);

        Console.WriteLine(acc1.Balance);
        Console.WriteLine(acc2.Balance);
        Console.WriteLine(acc3.Balance);

    }

}