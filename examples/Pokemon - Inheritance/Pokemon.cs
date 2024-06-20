/*
 * This is an abstract class called Pokemon. An abstract class is like a blueprint for creating other classes.
 * It contains methods and properties that other classes can inherit from. However, you can't create an instance
 * of an abstract class. Think of it like a general idea of what a Pokemon is, but it's not a specific
 * Pokemon itself.
 */
abstract class Pokemon
{
    /*
     * These are private fields. They store information about the Pokemon, like its name and level.
     * Private means they can only be accessed within this class.
     */
    private string name;
    private int level;

    /*
     * This is a constructor. It's a special method that gets called when you create a new instance of a class.
     * In this case, it's setting the name and level of the Pokemon when you create a new one.
     */
    public Pokemon(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    /*
     * These are methods to get the name and level of the Pokemon.
     * They're public, which means they can be accessed from outside this class.
     */
    public string GetName()
    {
        return name;
    }

    public int GetLevel()
    {
        return level;
    }

    /*
     * This is an abstract method. It's a method that doesn't have any implementation in this class.
     * Instead, any class that inherits from Pokemon will have to provide its own implementation of
     * this method. It's like saying, "All Pokemon can attack, but each one does it in a different way."
     */
    public abstract void Attack();

    /*
     * This is a method to display information about the Pokemon.
     * It uses Console.WriteLine to print a message to the console.
     */
    public void Display()
    {
        Console.WriteLine($"{name} (Level {level}) is ready to battle!");
    }
}