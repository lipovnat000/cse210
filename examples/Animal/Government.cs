static class Government
{
    // Static method to check if the animal can be played with (abstraction + encapsulation)
    public static bool CanPlayWithAnimal(string species)
    {
        if (species == "Dog" || species == "Cat")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}