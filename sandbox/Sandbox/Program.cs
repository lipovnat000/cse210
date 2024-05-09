using System;

class Program
{
    static void Main(string[] args)
    {
        Person fred = new Person("Fred", "Flintstone");
        Person steve = new Person("Steve", "Rogers");

        fred.EasternStyleName();
        steve.WesternStyleName();
    }
}