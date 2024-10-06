using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ScriptureMemorization
{
    // Class to represent a scripture reference
    public class ScriptureReference
    {
        public string Book { get; }
        public int StartVerse { get; }
        public int? EndVerse { get; }

        public ScriptureReference(string book, int startVerse, int? endVerse = null)
        {
            Book = book;
            StartVerse = startVerse;
            EndVerse = endVerse;
        }

        public override string ToString()
        {
            return EndVerse.HasValue ? $"{Book} {StartVerse}-{EndVerse}" : $"{Book} {StartVerse}";
        }
    }

    // Class to represent a word in the scripture
    public class Word
    {
        public string Text { get; private set; }
        public bool IsHidden { get; private set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }

        public override string ToString()
        {
            return IsHidden ? "_" : Text;
        }
    }

    // Class to represent the scripture text
    public class Scripture
    {
        public ScriptureReference Reference { get; }
        private List<Word> Words { get; }
        
        public Scripture(ScriptureReference reference, string text)
        {
            Reference = reference;
            Words = text.Split(' ').Select(w => new Word(w)).ToList();
        }

        public void HideRandomWord()
        {
            var random = new Random();
            var index = random.Next(Words.Count);
            if (!Words[index].IsHidden)
            {
                Words[index].Hide();
            }
        }

        public bool AllWordsHidden()
        {
            return Words.All(w => w.IsHidden);
        }

        public override string ToString()
        {
            return $"{Reference}\n" + string.Join(" ", Words);
        }
    }

    // Main program class
    public class Program
    {
        static void Main(string[] args)
        {
            var scriptures = LoadScriptures("scriptures.txt");
            var random = new Random();
            var currentScripture = scriptures[random.Next(scriptures.Count)];

            while (true)
            {
                Console.Clear();
                Console.WriteLine(currentScripture);
                Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");

                var input = Console.ReadLine();
                if (input?.ToLower() == "quit") break;

                currentScripture.HideRandomWord();

                if (currentScripture.AllWordsHidden())
                {
                    Console.Clear();
                    Console.WriteLine("All words hidden! Exiting...");
                    break;
                }
            }
        }

        private static List<Scripture> LoadScriptures(string filePath)
        {
            var scriptures = new List<Scripture>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 2)
                {
                    var reference = new ScriptureReference(parts[0].Trim(), int.Parse(parts[1].Trim()));
                    scriptures.Add(new Scripture(reference, parts[1].Trim()));
                }
            }

            return scriptures;
        }
    }
}