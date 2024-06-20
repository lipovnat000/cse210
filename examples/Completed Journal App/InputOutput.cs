public class InputOutput
{
    private string storageDir;

    /// <summary>
    /// Initializes a new instance of the InputOutput class with the specified storage directory.
    /// </summary>
    /// <param name="storageDir">The directory where files will be stored.</param>
    public InputOutput(string storageDir)
    {
        this.storageDir = storageDir;
        EnsureDirExists();
    }

    /// <summary>
    /// Ensures that the storage directory exists. If it doesn't, creates the directory.
    /// </summary>
    private void EnsureDirExists()
    {
        if (!Directory.Exists(this.storageDir))
        {
            Directory.CreateDirectory(this.storageDir);
        }
    }

    /// <summary>
    /// Gets a list of journal names from the storage directory.
    /// </summary>
    /// <returns>A list of journal names.</returns>
    public List<string> GetJournals()
    {
        List<string> journals = new List<string>();
        foreach (string file in Directory.GetFiles(this.storageDir, "*.txt"))
        {
            journals.Add(Path.GetFileNameWithoutExtension(file));
        }
        return journals;
    }

    /// <summary>
    /// Checks if a file exists in the storage directory.
    /// </summary>
    /// <param name="filePath">The relative path of the file.</param>
    /// <returns>True if the file exists, otherwise false.</returns>
    public bool FileExists(string filePath)
    {
        string path = Path.Combine(this.storageDir, filePath);
        if (File.Exists(path))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Loads the content of a file from the storage directory.
    /// </summary>
    /// <param name="filename">The name of the file to load.</param>
    /// <returns>An array of strings representing the lines of the file, or null if the file doesn't exist.</returns>
    public string[] LoadFile(string filename)
    {
        string path = Path.Combine(this.storageDir, filename);
        if (File.Exists(path))
        {
            return File.ReadAllLines(path);
        }
        else
        {
            return null;
        }
    }

    /// <summary>
    /// Writes the content to a file in the storage directory.
    /// </summary>
    /// <param name="filename">The name of the file to write.</param>
    /// <param name="content">An array of strings representing the lines to write to the file.</param>
    public void WriteFile(string filename, string[] content)
    {
        string path = Path.Combine(this.storageDir, filename);
        File.WriteAllLines(path, content);
    }
}
