using System.Diagnostics;

abstract class Activity {

    // Variables to be set in the derived classes
    protected string activityName;
    protected string activityDescription;

    public void Introduction()
    {
        Console.Clear();
        Console.WriteLine($"\nThis is the {activityName} activity\n");
        Console.WriteLine(activityDescription+"\n");
    }

    public int GetDuration() {
        Console.Write("How long, in seconds, would you like for your session? ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public void Run() {
        Introduction();
        int duration = GetDuration();
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        Pause(5, "circle");
        Console.Clear();
        
        Start(duration);
        
        Pause(3, "circle");
        
        End(duration);        
    }

    public abstract void Start(int duration);

    public void Pause(int pauseTimer, string type)
    {

        Stopwatch stopwatch = new Stopwatch();

        Console.CursorVisible = false;

        stopwatch.Start();

        while (stopwatch.Elapsed.Seconds < pauseTimer) {
            if (type == "dot") {
                Console.Write(".");
                Thread.Sleep(1000);
            } else if (type == "circle") {
                Console.Write("|");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }

        stopwatch.Stop();

        Console.CursorVisible = true;
    }

    public void End(int duration)
    {
        Console.WriteLine("\n\nWell Done!");
        Pause(3, "circle");
        Console.WriteLine($"\n\nYou've completed {duration} seconds of the {activityName} activity");
        Pause(3, "circle");
    }
}