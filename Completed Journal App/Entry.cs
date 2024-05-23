public class Entry
{
    // The date and time the entry was created
    public string created { get; set; }

    // The text of the entry
    public string entryText { get; set; }

    // The prompt associated with the entry
    public string prompt { get; set; }

    // Constructor for the Entry class
    public Entry(string created, string prompt, string entryText)
    {
        this.created = created;
        this.prompt = prompt;
        this.entryText = entryText;
    }

    // Displays the entry to the console
    public void Display()
    {
        Console.WriteLine(ToString());
    }

    // Stores the entry as a string
    public string StoreEntry()
    {
        // Implementation to store the entry as a string
        return $"{created}<|>{prompt}<|>{entryText}";
    }

    // Returns a string representation of the entry
    public override string ToString()
    {
        return $"{created} - {prompt}\n{entryText}\n";
    }

    // Updates the entry with new text
    public void UpdateEntry(string entryText)
    {
        this.entryText = entryText;
    }
}
