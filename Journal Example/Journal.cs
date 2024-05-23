class Journal {

    private List<Entry> entries = new List<Entry>();

    public void NewEntry() {
        string prompt = "What is on your mind today";
        Console.WriteLine($"{prompt}?");

        string response = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Entry entry = new Entry(dateText, prompt, response);

        entries.Add(entry);
    }

    public void DisplayEntries() {
        Console.WriteLine("Journal Entries");
        Console.WriteLine("-----------------");
        foreach (Entry entry in entries) {
            entry.Display();
        }
    }

    public void DisplayLastEntry() {
        if (entries.Count > 0) {
            Console.WriteLine("Last Entry");
            Console.WriteLine("-----------------");
            entries[entries.Count - 1].Display();
        } else {
            Console.WriteLine("No entries yet.");
        }
    }
}