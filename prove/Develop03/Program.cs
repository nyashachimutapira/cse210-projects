using System;
using System.Collections.Generic;

public class Scripture
{
    public string Reference { get; }
    public string Text { get; }
    private List<string> hiddenWords;

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
        hiddenWords = new List<string>();
    }

    public void HideWords()
    {
        string[] words = Text.Split(' ');
        Random random = new Random();
        int numWordsToHide = random.Next(1, words.Length);

        for (int i = 0; i < numWordsToHide; i++)
        {
            int wordIndex = random.Next(0, words.Length);
            if (!hiddenWords.Contains(words[wordIndex]))
            {
                hiddenWords.Add(words[wordIndex]);
                words[wordIndex] = new string('_', words[wordIndex].Length);
            }
        }

        Console.WriteLine($"{Reference}:");
        Console.WriteLine(string.Join(" ", words));
    }

    public bool AllWordsHidden()
    {
        return hiddenWords.Count == Text.Split(' ').Length;
    }
}

public class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int VerseStart { get; }
    public int VerseEnd { get; }

    public Reference(string book, int chapter, int verseStart)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verseStart;
        VerseEnd = verseStart;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verseStart;
        VerseEnd = verseEnd;
    }

    public override string ToString()
    {
        if (VerseStart == VerseEnd)
        {
            return $"{Book} {Chapter}:{VerseStart}";
        }
        else
        {
            return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
        }
    }
}

public class Word
{
    public string Text { get; }

    public Word(string text)
    {
        Text = text;
    }
}

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Console.WriteLine("Press Enter to start or type 'quit' to exit.");
        string userInput = Console.ReadLine();

        while (userInput != "quit" && !scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.HideWords();

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            userInput = Console.ReadLine();
        }

        Console.WriteLine("End of Program.");
    }
}