// Importing the necessary namespace
using System;

// Defining the Listing class which inherits from the Activity class
class Listing : Activity {
    // Overriding the Run method from the base class
    public override void Run()
    {
        // Printing a message to the console
        Console.WriteLine("Running Listing Activity");

        // Calling the Loading method of the current instance
        this.Loading();
    }
}