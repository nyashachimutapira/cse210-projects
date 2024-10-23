using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    /// <summary>
    /// Represents the journal that holds entries.
    /// </summary>
    public class Journal
    {
        private List<Entry> _entries;
        private static readonly string[] _prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        public Journal()
        {
            _entries = new List<Entry>();
        }

        /// <summary>
        /// Adds a new entry to the journal.
        /// </summary>
        /// <param name="response">The user's response to the prompt.</param>
        public void AddEntry(string response)
        {
            string date = DateTime.Now.ToShortDateString();
            string prompt = GetRandomPrompt();
            _entries.Add(new Entry(date, prompt, response));
        }

        /// <summary>
        /// Displays all entries in the journal.
        /// </summary>
        public void DisplayEntries()
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

        /// <summary>
        /// Saves the journal entries to a file.
        /// </summary>
        /// <param name="filename">The name of the file to save to.</param>
        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry.Date}~{entry.Prompt}~{entry.Response}");
                }
            }
        }

        /// <summary>
        /// Loads journal entries from a file.
        /// </summary>
        /// <param name="filename">The name of the file to load from.</param>
        public void LoadFromFile(string filename)
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                var parts = line.Split('~');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }
        }

        /// <summary>
        /// Gets a random prompt from the predefined prompts.
        /// </summary>
        private string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Length);
            return _prompts[index];
        }
    }
}