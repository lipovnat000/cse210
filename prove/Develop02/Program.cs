using System;
using System.Diagnostics;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string filename = "journal.txt";

        Console.Write("What is the filename (without extension)? Enter the name of a new file if you want to create one: ");
        filename = Console.ReadLine();

        Journal journal = new Journal(filename);

        string entry = "";
        string prompt = null;

        int choice = 0;

        Console.WriteLine(@"Please select one of the following choices:
    1. Write
    2. Display
    3. Load
    4. Save
    5. Quit");

        do {
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1) {
                prompt = journal.GeneratePrompt();
                Console.WriteLine(prompt);
                entry = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(entry)) {
                    break;
                } else {
                    journal.AddEntry(entry, prompt);
                }
            } 
            else if (choice == 2) {
                journal.DisplayAll();
            } else if (choice == 3) {
                journal.LoadFile();
            } else if (choice == 4) {
                journal.SaveToFile();
            }
       }while (choice != 5);
    }
}