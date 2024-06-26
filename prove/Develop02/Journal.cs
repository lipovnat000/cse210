using System;
using System.Runtime.CompilerServices;

class Journal {

    List<string> entries = new List<string>();
    string filename;

    List<string> prompts = new List<string>();

    public Journal(string filename) {
        this.filename = filename;
    }

    public void AddEntry(string entry, string prompt) {
        if (prompt != null) {
            entries.Add($"{DateTime.Now.ToString("MM-dd-yyyy")}: {prompt}: {entry}");    
        } else {
            entries.Add($"{DateTime.Now.ToString("MM-dd-yyyy")}: {entry}");        
        }
    }

    public void LoadFile() {
        File.OpenRead(filename);
        entries = File.ReadAllLines(filename).ToList();
    }

    public void SaveToFile() {
        File.AppendAllLines(filename, entries);
    }

    public void DisplayAll() {
        foreach (string entry in entries) {
            Console.WriteLine(entry);
        }
    }

    public string GeneratePrompt() {
        prompts = File.ReadAllLines("prompts.txt").ToList();
        Console.WriteLine("Would you like a prompt (y/n)?");
        string response = Console.ReadLine();

        if (response == "y") {
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(prompts.Count);
            
            return prompts[index];
        } else {
            return null;
        }
    }
}