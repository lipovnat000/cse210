using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(""); // Add space to the demos output

        /*
         * The following line is a shorthand for: Animal dog = new Animal("Dog", "Clifford");
         */
        Animal dog = new("Dog", "Clifford");
        dog.PlayWithAnimal();
    }
}

