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

    public bool Execute(int choice, GoalList goals){
        switch (choice){
            case 1:
                goals.AppendGoal();
                return true;
            case 2:
                goals.ListGoals();
                return true;
            case 3:
                goals.Save();
                return true;
            case 4:
                goals.Load();
                return true;
            case 5:
                goals.RecordEvent();
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