// Program.cs
using System;

class Program
/* The `{` symbol in C# is used to denote the beginning of a code block. In the context of the code you
provided, the `{` symbol is used to start the block of code for the `Main` method of the `Program`
class. This block of code contains the logic that will be executed when the program runs. */
{
    static void Main(string[] args)
    {
        var scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding.");

        while (true)
        {
            Reference theReference = new Reference();
            Word theWord = new Word();
            Scripture theScripture = new Scripture();
            Console.Clear();
            Console.WriteLine(scripture.GetFullText());
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are now hidden!");
                break;
            }
        }
    }
}

internal class Reference
{
    public Reference()
    {
    }
}

internal class Scripture
{
    private string v1;
    private string v2;

    public Scripture()
    {
    }

    public Scripture(string v1, string v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    internal bool AllWordsHidden()
    {
        throw new NotImplementedException();
    }

    internal bool GetFullText()
    {
        throw new NotImplementedException();
    }

    internal void HideRandomWord()
    {
        throw new NotImplementedException();
    }
}