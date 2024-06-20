class Menu(){

    private string[] menuOptions = {
        "Breathing Activity",
        "Reflecting Activity",
        "Listing Activity",
        "Quit"
    };

    public void DisplayMenu(){
        Console.WriteLine("\nMenu Options:");
        for (int i = 0; i < menuOptions.Length; i++){
            Console.WriteLine($"  {i + 1}. {menuOptions[i]}");
        }
    }

    public int GetChoice(){
        int choice = Convert.ToInt32(Console.ReadLine());
        return choice;
    }

    public void Execute(int choice){
        switch (choice){
            case 1:
                // Create an instance of Breathing class and run it
                Breathing breathing = new Breathing();
                breathing.Run();
                break;
            case 2:
                // Create an instance of Reflecting class and run it
                Reflecting reflecting = new Reflecting();
                reflecting.Run();
                break;
            case 3:
                // Create an instance of Listing class and run it
                Listing listing = new Listing();
                listing.Run();
                break;
            case 4:
                // Quit the program
                Console.WriteLine("Goodbye!");
                running = false;
                break;
            default:
                // Invalid option, display error message
                Console.WriteLine("Invalid option please try again.");
                break;
        }
    }

}