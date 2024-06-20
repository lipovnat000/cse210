using System;

/// <summary>
/// Represents the entry point of the program.
/// </summary>
class Program
{
    /// <summary>
    /// The main method that is called when the program starts.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        bool keepRunning = true;
        while(keepRunning)
        {
            // Call the ChooseAndRun method of the menu and store the result in keepRunning.
            keepRunning = menu.ChooseAndRun();
        }
    }
}