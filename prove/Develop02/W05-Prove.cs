using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }
    }

    static List<Entry> journal = new List<Entry>();
    static string[] prompts = { "Who was the most interesting person I interacted with today?",
                                "What was the best part of my day?",
                                "How did I see the hand of the Lord in my life today?",
                                "What was the strongest emotion I felt today?",
                                "If I had one thing I could do over today, what would it be?" };
    
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("\n1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("\nEnter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    WriteNewEntry();
                    break;
                case 2:
                    DisplayJournal();
                    break;
                case 3:
                    SaveJournal();
                    break;
                case 4:
                    LoadJournal();
                    break;
            }
        } while (choice != 5);
    }

    static void WriteNewEntry()
    {
        int index = new Random().Next(prompts.Length);
        Console.WriteLine("\n" + prompts[index]);
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();
        Entry entry = new Entry
        {
            Prompt = prompts[index],
            Response = response,
            Date = DateTime.Now
        };
        journal.Add(entry);
        Console.WriteLine("\nEntry saved successfully");
    }

    static void DisplayJournal()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in journal)
        {
            Console.WriteLine("\nPrompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
        }
    }

    static void SaveJournal()
    {
        Console.Write("\nEnter the file name: ");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in journal)
            {
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.Response);
                writer.WriteLine(entry.Date);
            }
        }
        Console.WriteLine("\nJournal saved successfully");
    }

    static void LoadJournal()
    {
        Console.Write("\nEnter the file name: ");
        string fileName = Console.ReadLine();
        journal.Clear();
        using (StreamReader reader = new
