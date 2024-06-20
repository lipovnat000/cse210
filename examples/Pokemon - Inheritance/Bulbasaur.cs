// Define a class called Bulbasaur that inherits from the Pokemon class
class Bulbasaur : Pokemon
{
    // Constructor for creating a Bulbasaur object with a specified level
    public Bulbasaur(int level) : base("Bulbasaur", level) { }

    // Override the Attack method from the base class
    public override void Attack()
    {
        // Prints the attack message using the GetName() method
        Console.WriteLine($"{GetName()} uses Vine Whip!");
    }
}