using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("\nThank you for using the Scripture Memorizer!");
    }
}