class Menu{

    private string[] menuOptions = {
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load Goals",
        "Record Event",
        "Quit"
    };

    public void DisplayMenu(){
        Console.Clear();
        Console.WriteLine("\nMenu Options:");
        for (int i = 0; i < menuOptions.Length; i++){
            Console.WriteLine($"  {i + 1}. {menuOptions[i]}");
        }
    }

    public int GetChoice(){
        int result;
        while (true)
        {
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

    public bool Execute(int choice){
        switch (choice){
            case 1:
                // Create an instance of Goal class and run it
                Goal goal = new Goal();
                goal.CreateGoalSelect();
                return true;
            case 2:
                // Create an instance of List class and run it
                List list = new List();
                list.Run();
                return true;
            case 3:
                // Create an instance of Save class and run it
                Save save = new Save();
                save.Run();
                return true;
            case 4:
                // Create an instance of Load class and run it
                Load load = new Load();
                load.Run();
                return true;
            case 5:
                // Create an instance of Record class and run it
                Record record = new Record();
                record.Run();
                return true;
            case 6:
                // Quit the program
                Console.WriteLine("Goodbye!");
                return false;
            default:
                // Invalid option, display error message    
                Console.WriteLine("Invalid option please try again.");
                return true;
        }
    }
}