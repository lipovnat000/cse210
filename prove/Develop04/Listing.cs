using System.Diagnostics;

class Listing : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing() {
        activityName = "Listing";
        activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Start(int duration) {
        Random random = new Random();
        int index = random.Next(prompts.Length);

        Console.WriteLine(prompts[index]);
        Console.WriteLine("\n\n\n");
        Console.WriteLine("List as many responses you can to the prompt above.");

        Console.Write("3, ");
        Thread.Sleep(1000);
        Console.Write("2, ");
        Thread.Sleep(1000);
        Console.Write("1");
        Thread.Sleep(1000);

        Console.WriteLine("\n\n\n");

        Stopwatch activityTimer = new Stopwatch();

        activityTimer.Start();
        
        while (activityTimer.Elapsed.Seconds < duration) {
            Console.Write("> ");
            Console.ReadLine();
        }
    }
}

