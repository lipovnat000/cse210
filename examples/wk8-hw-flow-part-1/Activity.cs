abstract class Activity {

    // Method for displaying a loading spinner for a specified number of seconds
    // Parameters:
    //   seconds (optional): The number of seconds to display the spinner (default is 3 seconds)
    //   speed (optional): The speed at which the spinner rotates (default is 200 milliseconds)
    public virtual void Loading(int seconds = 3, int speed = 200) {
        string[] spinner = { "|", "/", "-", "\\" }; // Array of spinner characters
        int runTime = seconds * 1000; // Convert seconds to milliseconds
        while (runTime > 0) {
            for (int i = 0; i < 3; i++) {
                Console.Write(spinner[i]); // Display the current spinner character
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Move the cursor back one position
                System.Threading.Thread.Sleep(speed); // Pause for the specified speed
                runTime -= speed; // Decrease the remaining runtime by the speed
                Console.Write(" "); // Clear the spinner character
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Move the cursor back one position
            }
        }
    }

    // Abstract method that must be implemented by derived classes
    public abstract void Run();
    
    // Method for pausing the execution for a specified number of seconds
    // Parameters:
    //   seconds (optional): The number of seconds to sleep (default is 3 seconds)
    public virtual void Sleep(int seconds = 3) {
        System.Threading.Thread.Sleep(seconds * 1000); // Convert seconds to milliseconds and pause the execution
    }
}