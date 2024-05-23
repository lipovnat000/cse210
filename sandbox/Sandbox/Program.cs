using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Person fred = new Person("Fred", "Flintstone");
        Person steve = new Person("Steve", "Rogers");

        fred.EasternStyleName();
        steve.WesternStyleName();


        Bank bank = new Bank();

        Console.WriteLine($"You have ${bank.GetAccountBalance()}");

        bank.Withdraw();

        Console.WriteLine($"You have ${bank.GetAccountBalance()}");
    }
}