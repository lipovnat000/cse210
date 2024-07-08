using System.Diagnostics;

class Breathing : Activity
{

    public Breathing() {
        activityName = "Breathing";
        activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Start(int duration) {

        Stopwatch activityTimer = new Stopwatch();
        activityTimer.Start();

        while (activityTimer.Elapsed.Seconds < duration) {
            Console.WriteLine("Now inhale...");
            Pause(3, "dot");
            Console.WriteLine("\nAnd exhale...");
            Pause(3, "dot");
            Console.WriteLine("\nBreathe in...");
            Pause(3, "dot");
            Console.WriteLine("\nBreathe out...");
            Pause(3, "dot");
            Console.WriteLine("\n");
        }

        activityTimer.Stop();
    }


}
