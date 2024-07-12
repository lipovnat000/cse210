class Menu(){

    private string[] menuOptions = {
        "Breathing Activity",
        "Reflecting Activity",
        "Listing Activity",
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
                // Create an instance of Breathing class and run it
                Breathing breathing = new Breathing();
                breathing.Run();
                return true;
            case 2:
                // Create an instance of Reflecting class and run it
                Reflecting reflecting = new Reflecting();
                reflecting.Run();
                return true;
            case 3:
                // Create an instance of Listing class and run it
                Listing listing = new Listing();
                listing.Run();
                return true;
            case 4:
                // Quit the program
                Console.WriteLine("Goodbye!");
                return false;
            default:
                // Invalid option, display error message
                Console.Clear();
                Console.WriteLine("Invalid option please try again.");
                Thread.Sleep(1500);
                return true;
        }
    }

}