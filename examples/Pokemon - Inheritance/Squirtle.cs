// Defining the Squirtle  class which inherits from the Pokemon class
class Squirtle  : Pokemon
{
    // Constructor for creating a Squirtle  object with a specified level
    public Squirtle (int level) : base("Squirtle ", level) { }

    // Overriding the Attack method from the base class
    public override void Attack()
    {
        // Printing a message indicating that Squirtle is using Water Gun
        Console.WriteLine($"{GetName()} uses Water Gun!");
    }
}