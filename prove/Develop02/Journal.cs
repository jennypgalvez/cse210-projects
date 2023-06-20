class Journal
{   
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public bool LoadedFromFile { get; set; }

    public void AddEntry (Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries) 
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Response: {entry._entryText}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                file.WriteLine(entry._date);
                file.WriteLine(entry._promptText);
                file.WriteLine(entry._entryText);
            }
        }
    }
    public void LoadFromFile(String filename)
    {
        _entries.Clear();

         if (File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            int numLines = lines.Length;

            for (int i = 0; i < lines.Length; i += 3)
            {
                if (i + 2 < numLines) 
                {
                    Entry entry = new Entry();
                    entry._date = lines[i];
                    entry._promptText = lines[i + 1];
                    entry._entryText = lines[i + 2];
                    _entries.Add(entry);
                }
                else 
                {
                    Console.WriteLine("Invalid format in the file. Skipping entry.");
                }
               
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

}    