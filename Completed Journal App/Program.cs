class Program
{
    static void Main(string[] args)
    {   
        // Create an instance of the InputOutput class to handle file input/output operations for journals
        InputOutput jio = new InputOutput("journals");
        
        // Initialize a variable to hold the current journal
        Journal journal = null;

        // Create a list of menu options
        List<string> menu = new List<string>
        {
            "New Entry",
            "Display Entries",
            "Display Specific Entry",
            "Load Journal",
            "Save Journal",
            "Quit"
        };

        // Start an infinite loop to display the menu and handle user input
        while (true)
        {
            // Check if a journal is currently loaded
            if (journal == null)
            {
                // Get the list of available journals
                List<string> journals = jio.GetJournals();

                // Check if there are any journals available
                if (journals.Count > 0)
                {
                    Console.WriteLine("Which Journal would you like to load? Enter 0 to create a new journal.");
                    
                    // Display the available journals
                    for (int i = 0; i < journals.Count; i++)
                    {
                        Console.WriteLine($"[{i + 1}] {journals[i]}");
                    }

                    // Get the user's choice
                    int option = Convert.ToInt32(Console.ReadLine()) - 1;

                    // Check if the user's choice is valid
                    if (option >= 0 && option < journals.Count)
                    {
                        // Load the selected journal
                        journal = new Journal($"{journals[option]}.txt");
                        continue;
                    }
                }

                // Prompt the user to create a new journal
                Console.WriteLine("Please create a new journal. Enter the name of the new journal:");
                string journalName = Console.ReadLine();
                journal = new Journal(journalName);
            }

            // Display the menu options
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }

            // Get the user's choice
            string choice = Console.ReadLine();

            // Handle the user's choice
            if (choice == "1")
            {
                journal.NewEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayAllEntries();
            }
            else if (choice == "3")
            {
                journal.DisplayEntry();
            }
            else if (choice == "4")
            {
                journal.SaveJournal();
                journal = null;
                continue;
            }
            else if (choice == "5")
            {
                journal.SaveJournal();
            }
            else if (choice == "6")
            {
                journal.SaveJournal();
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice please try again.");
            }
        }
    }
}