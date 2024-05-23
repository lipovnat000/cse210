public class Journal
{
    private List<Entry> entries = new List<Entry>(); // List to store journal entries
    private InputOutput jio; // InputOutput object for file operations
    private string journalName; // Name of the journal

    /// <summary>
    /// Initializes a new instance of the Journal class.
    /// </summary>
    /// <param name="journalName">The name of the journal.</param>
    /// <param name="storageDir">The storage directory for the journal file.</param>
    public Journal(string journalName, string storageDir = "journals")
    {
        jio = new InputOutput(storageDir);
        string sanitizedName = $"{SanitizeJournalName(journalName)}.txt";

        // Check if the journal file exists
        if (!jio.FileExists(sanitizedName))
        {
            CreateNewJournal(journalName);
        }
        else
        {
            this.journalName = sanitizedName;
            LoadJournal();
        }
    }

    /// <summary>
    /// Sanitizes the journal name by replacing spaces with hyphens and removing invalid characters.
    /// </summary>
    /// <param name="journalName">The journal name to sanitize.</param>
    /// <returns>The sanitized journal name.</returns>
    private string SanitizeJournalName(string journalName)
    {
        string sanitizedJournalName = journalName.Replace(" ", "-");
        sanitizedJournalName = Path.GetInvalidFileNameChars()
            .Aggregate(
                sanitizedJournalName,
                (current, c) => current.Replace(c.ToString(), string.Empty)
            );

        // Remove file extension if present
        sanitizedJournalName = Path.GetFileNameWithoutExtension(sanitizedJournalName);

        return sanitizedJournalName;
    }

    /// <summary>
    /// Creates a new journal file with the given name.
    /// </summary>
    /// <param name="journalName">The name of the journal.</param>
    private void CreateNewJournal(string journalName)
    {
        this.journalName = $"{this.SanitizeJournalName(journalName)}-{DateTime.Now:yyyy-MM-dd}.txt";
        this.SaveJournal();
    }

    /// <summary>
    /// Displays a specific journal entry based on user input.
    /// </summary>
    public void DisplayEntry()
    {
        Console.WriteLine("Which entry would you like to display?");

        // Display all journal entries with their index
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"[{entries.IndexOf(entry) + 1}] {entry.created} - {entry.prompt}");
        }

        int index = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine($"Journal Entry #{index + 1}");
        Console.WriteLine("-----------------");

        if (index >= 0 && index < entries.Count)
        {
            entries[index].Display();
        }
        else
        {
            Console.WriteLine("Invalid entry number.");
        }
    }

    /// <summary>
    /// Displays all journal entries.
    /// </summary>
    public void DisplayAllEntries()
    {
        Console.WriteLine("Journal Entries");
        Console.WriteLine("-----------------");

        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    /// <summary>
    /// Parses the entry data and returns a dictionary containing the entry parts.
    /// </summary>
    /// <param name="entryData">The entry data to parse.</param>
    /// <returns>A dictionary containing the entry parts.</returns>
    private Dictionary<string, object> GetEntryParts(string entryData)
    {
        string[] parts = entryData.Split("<|>");

        return new Dictionary<string, object>
        {
            { "created", parts[0] },
            { "prompt", parts[1] },
            { "entryText", parts[2] }
        };
    }

    /// <summary>
    /// Loads the journal entries from the journal file.
    /// </summary>
    /// <summary>
    /// Loads the journal entries from the journal file.
    /// </summary>
    private void LoadJournal()
    {
        // Load the contents of the journal file
        string[] lines = jio.LoadFile(this.journalName);

        // Check if the file is not empty
        if (lines != null)
        {
            // Iterate through each line in the file
            foreach (string line in lines)
            {
                // Parse the entry parts from the line
                Dictionary<string, object> entryParts = GetEntryParts(line);

                // Create a new Entry object using the parsed parts
                Entry entry = new Entry(
                    (string)entryParts["created"],
                    (string)entryParts["prompt"],
                    (string)entryParts["entryText"]
                );

                // Add the entry to the list of entries
                entries.Add(entry);
            }
        }
    }

    /// <summary>
    /// Creates a new journal entry.
    /// </summary>
    public void NewEntry()
    {
        string prompt = PromptGenerator.GetPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
        this.entries.Add(entry);
    }

    /// <summary>
    /// Saves the journal entries to the journal file.
    /// </summary>
    public void SaveJournal()
    {
        if (entries.Count == 0)
        {
            jio.WriteFile(journalName, []); // Empty array passed to WriteFile method
        }
        else
        {
            string[] lines = entries.Select(entry => entry.StoreEntry()).ToArray();
            jio.WriteFile(journalName, lines);
        }
    }

    /// <summary>
    /// Updates a specific journal entry based on user input.
    /// </summary>
    /// <summary>
    /// Updates a specific journal entry based on user input.
    /// </summary>
    public void UpdateEntry()
    {
        Console.WriteLine("Which entry would you like to update?");

        // Display all journal entries with their index
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"[{entries.IndexOf(entry) + 1}] {entry.created} - {entry.prompt}");
        }

        int index = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine($"Journal Entry #{index + 1}");
        Console.WriteLine("-----------------");

        if (index >= 0 && index < entries.Count)
        {
            Console.WriteLine("Enter new response:");
            entries[index].entryText = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid entry number.");
        }
    }
}
