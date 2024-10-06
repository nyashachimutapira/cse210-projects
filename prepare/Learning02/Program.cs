using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    journal.WriteNewEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    Console.WriteLine("Enter a filename to save to:");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    break;
                case 4:
                    Console.WriteLine("Enter a filename to load from:");
                    filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                    break;
                case 5:
                    return;
            }
        }
    }
}

class Journal
{
    private List<Entry> entries;
    private List<string> prompts;

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };
    }

    public void WriteNewEntry()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, response, DateTime.Now);
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine("Date: {0}\nPrompt: {1}\nResponse: {2}\n", entry.Date, entry.Prompt, entry.Response);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine("{0},{1},{2}", entry.Date, entry.Prompt, entry.Response);
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string response = parts[2];

                Entry entry = new Entry(prompt, response, date);
                entries.Add(entry);
            }
        }
    }
}

class Entry

{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}