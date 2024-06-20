using System;
using System.Diagnostics;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string entry;
        string filename = "";

        int choice = 0;

        Console.WriteLine(@"Please select one of the following choices:
    1. Write
    2. Display
    3. Load
    4. Save
    5. Quit");

        while (choice != 5) {
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1) {

                if (string.IsNullOrWhiteSpace(entry)) {
                    break;
                } else {
                    journal.AddEntry(entry);
                }
            } else if (choice == 2) {
                journal.DisplayAll(filename);
            }
        }
    }
}