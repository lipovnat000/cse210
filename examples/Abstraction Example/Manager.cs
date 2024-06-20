class Manager
{
    List<Worker> workers = new List<Worker>();
    Job job = new Job();

    public Manager(int numberOfWorkers)
    {
        Console.WriteLine("Hello I am the Manager class, I \"manage\" the \"workers\".");
        Thread.Sleep(1000); // Sleep for 1 second
        Console.WriteLine($"I have been assigned {numberOfWorkers} workers.");
        Thread.Sleep(1000); // Sleep for 1 second

        for (int i = 0; i < numberOfWorkers; i++)
        {
            workers.Add(new Worker(i + 1, job.GetJob()));
            Thread.Sleep(1000); // Sleep for 1 second
        }
    }

    public void DoWork()
    {
        Console.WriteLine("Manager doing work...");
        Thread.Sleep(1000); // Sleep for 1 second

        foreach (Worker worker in workers)
        {
            worker.DoWork();
            Thread.Sleep(1000); // Sleep for 1 second
        }
    }

    public void EndOfDayReport()
    {
        Console.WriteLine("\nManager end of day Report");
        Console.WriteLine("----------------------------------------");
        foreach (Worker worker in workers)
        {
            worker.EndOfDayReport();
        }
        Console.WriteLine("\nEnd report.");
    }
}