// Defining the Pikachu class which inherits from the Pokemon class
class Pikachu : Pokemon
{
    // Constructor for creating a Pikachu object with a specified level
    public Pikachu(int level) : base("Pikachu", level) {}

    // Overriding the Attack method from the base class
    public override void Attack()
    {
        // Printing a message indicating that Pikachu is using Thunderbolt
        Console.WriteLine($"{GetName()} uses Thunderbolt!");
    }
}