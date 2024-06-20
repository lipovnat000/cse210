// Import the necessary namespace
using System;

// Define a class named Breathing that inherits from the Activity class
class Breathing : Activity
{
    // Override the Run method from the base class
    public override void Run()
    {
        // Print a message to the console indicating that the Breathing activity is running
        Console.WriteLine("Running Breathing Activity");

        // Call the Loading method of the current instance
        this.Loading();
    }
}