using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(""); // Add space to the demos output

        Pokemon pikachu = new Pikachu(5);
        pikachu.Display();
        pikachu.Attack();

        Console.WriteLine(""); // Add space to the demos output

        Pokemon charmander = new Charmander(10);
        charmander.Display();
        charmander.Attack();

        Console.WriteLine(""); // Add space to the demos output

        Pokemon bulbasaur = new Bulbasaur(8);
        bulbasaur.Display();
        bulbasaur.Attack();

        Console.WriteLine(""); // Add space to the demos output

        Pokemon squirtle = new Squirtle(7);
        squirtle.Display();
        squirtle.Attack();
    }
}

