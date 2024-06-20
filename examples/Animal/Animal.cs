class Animal {

    // Private fields (encapsulation)
    private string species;
    private string name;

    // Constructor to initialize the Animal object
    public Animal(string species, string name)
    {
        this.species = species;
        this.name = name;
    }

    public string GetSpecies()
    {
        return this.species;
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }
    
    // Public method to make sound (abstraction)
    public void MakeSound()
    {
        if (this.species == "Dog")
        {
            Console.WriteLine("Woof!");
        }
        else if (this.species == "Cat")
        {
            Console.WriteLine("Meow!");
        }
        else
        {
            Console.WriteLine("Unknown animal sound.");
        }
    }

    // Public method to play with the animal (abstraction)
    public void PlayWithAnimal()
    {
        if (Government.CanPlayWithAnimal(this.species))
        {
            Console.WriteLine($"You play with your {this.species} {this.name}.");
        }
        else
        {
            Console.WriteLine($"You cannot play with your {this.species} {this.name}.");
        }
    }
}