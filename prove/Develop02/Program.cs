using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            string userInput;

            do
            {
                Console.WriteLine("Journal Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display journal entries");
                Console.WriteLine("3. Save journal to file");
                Console.WriteLine("4. Load journal from file");
                Console.WriteLine("5. Exit");
                Console.Write("Please choose an option: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Please write your response:");
                        string response = Console.ReadLine();
                        journal.AddEntry(response);
                        break;

                    case "2":
                        journal.DisplayEntries();
                        break;

                    case "3":
                        Console.Write("Enter filename to save journal: ");
                        string saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                        Console.WriteLine("Journal saved successfully.");
                        break;

                    case "4":
                        Console.Write("Enter filename to load journal: ");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        Console.WriteLine("Journal loaded successfully.");
                        break;

                    case "5":
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (userInput != "5");
        }
    }
}