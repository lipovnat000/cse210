using System;

public class Job
{

    private string[] jobs = { "Print reports", "Clean bathrooms", "Send emails", "Make phone calls", "Schedule appointments", "Prepare presentations", "Organize files", "Assist with inventory management", "Update spreadsheets", "Coordinate meetings" };
    
    private Random random = new Random();

    public string GetJob()
    {
        int index = random.Next(jobs.Length);
        return jobs[index];
    }
}