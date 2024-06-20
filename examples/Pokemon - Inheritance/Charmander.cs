// Define a class called Charmander that inherits from the Pokemon class
class Charmander : Pokemon
{
    // Constructor for creating a Charmander object with a specified level
    public Charmander(int level) : base("Charmander", level) { }

    // Override the Attack method from the base class
    public override void Attack()
    {
        // Print a message indicating that Charmander is using Flamethrower
        Console.WriteLine($"{GetName()} uses Flamethrower!");
    }
}