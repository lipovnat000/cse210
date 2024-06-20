using System;

class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new Journal();

        List<string> menu = ["Write", "Display", "Display Last", "Load", "Save", "Quit"];

        Console.WriteLine("Explain what this app is briefly...");

        while (true)
        {
            Console.WriteLine("Choose an option:");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.NewEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                journal.DisplayLastEntry();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Load saved journal...");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Save current journal...");
            }
            else if (choice == "6")
            {
                Console.WriteLine("Quit Application");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}