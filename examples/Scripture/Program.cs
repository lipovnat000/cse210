using System;

class Program
{
    static void Main(string[] args)
    {
        
        Scripture scripture1 = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        scripture1.Practice();


        Scripture scripture2 = new Scripture("John", 3, 16, 17, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");
        scripture2.Practice(5);
    }
}