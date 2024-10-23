using System;
using MindfulnessProgram;

while (true)
{
    Console.Clear();
    Console.WriteLine("Mindfulness Program");
    Console.WriteLine("1. Start Breathing Activity");
    Console.WriteLine("2. Start Reflection Activity");
    Console.WriteLine("3. Start Listing Activity");
    Console.WriteLine("4. Quit");
    Console.Write("Select a choice from the menu: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            new BreathingActivity().Run();
            break;
        case "2":
            new ReflectionActivity().Run();
            break;
        case "3":
            new ListingActivity().Run();
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            System.Threading.Thread.Sleep(2000);
            break;
    }
}