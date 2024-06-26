using System;
using System.Runtime.CompilerServices;

class Journal {

    List<string> entries = new List<string>();
    string filename;

    public Journal(string filename) {
        this.filename = filename;
    }

    public void AddEntry(string entry) {
        entries.Add($"{DateTime.Now.ToString("MM-dd-yyyy")}: {entry}");
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
}