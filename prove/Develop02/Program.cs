using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private const string DefaultFileName = "journal.txt";
    private static Journal journal;
    static void Main(string[] args)
    {
       journal = new Journal();
       LoadJournal(DefaultFileName);
       bool exit = false;

       while (!exit)
       {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch(choice) 
        {
            case "1":
                WriteNewEntry();
                break;
            case "2":
                DisplayJournal();
                break;
            case "3":
                SaveJournal();
                break;
            case "4":
                LoadJournal();
                break;
            case "5":
                exit = true;
                break;   
            default: 
                Console.WriteLine("Invalid choice, Please try again");
                break;         

        }

        Console.WriteLine();

       }
    }

    static void WriteNewEntry()
    {
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString();
        entry._promptText = GetRandomPrompt();

        Console.WriteLine($"Prompt: {entry._promptText}");
        Console.Write("Response: ");
        entry._entryText = Console.ReadLine();

        journal.AddEntry(entry);
    }

    static string GetRandomPrompt()
    {
        List<string> prompts = new List<String>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        if (prompts.Count == 0)
        {
        Console.WriteLine("No prompts available.");
        return string.Empty;
        }

        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    static void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        journal.DisplayAll();

    }

    static void SaveJournal ()
    {
        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved successfully.");
    }

    static void LoadJournal(string filename = DefaultFileName)
    {
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded successfully.");
    }

}