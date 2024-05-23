using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello I am the Program class, I \"drive\" the program.");
        Thread.Sleep(2000); // Sleep for 2 second

        Manager manager = new Manager(5);
        manager.DoWork();
        manager.EndOfDayReport();
    }
}