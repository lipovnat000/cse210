using System.Diagnostics;

class Reflecting : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you learned something new.",
        "Think of a time when you felt like you were on top of the world."
    };

    private string[] responses = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    public Reflecting()
    {
        activityName = "Reflecting";
        activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void Start(int duration)
    {
      
        Stopwatch activityTimer = new Stopwatch();
        
        activityTimer.Start();

        while (activityTimer.Elapsed.Seconds < duration) {
            Random random = new Random();
            int index = random.Next(prompts.Length);
            Console.WriteLine(prompts[index]);

            Pause(10, "circle");
            Console.WriteLine("\n\n\n");
            random = new Random();
            index = random.Next(responses.Length);
            Console.WriteLine(responses[index]); 
            Pause(10, "circle");
            Console.WriteLine("\n\n\n");           
        }

        activityTimer.Stop();
    }
}

