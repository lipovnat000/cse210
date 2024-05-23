using System;

class Journal {

    public string name;
    List<string> entries = new List<string>();

    public void AddEntry(string entry) {
        entries.Add($"{DateTime.Now.ToString("MM-dd-yyyy")}: {entry}");
    }

    public void openFile(string filename) {
        File.OpenRead($"{filename}.txt");
    }

    public void SaveToFile(string filename) {
        File.AppendAllLines($"{filename}.txt", entries);
    }

    public void DisplayAll(string filename) {
        foreach (string entry in entries) {
            Console.WriteLine(entry);
        }
    }
}