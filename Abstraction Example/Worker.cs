class Worker
{
    private int number;
    private string job;

    public Worker(int number, string job)
    {   
        this.number = number;
        this.job = job;
        Console.WriteLine($"{number}: Hello I from the Worker class, I do \"work\" for the \"Manager\".");
        Console.WriteLine($"{number}: I have been assigned the job: {job}");   
    }

    public void DoWork()
    {
        Console.WriteLine($"Worker #{this.number} doing work...");
    }

    public void EndOfDayReport()
    {
        Console.WriteLine($"Worker #{this.number} completed: {this.job}");
    }
}