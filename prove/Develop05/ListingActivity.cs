using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// Represents a listing activity.
/// </summary>
public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    /// <summary>
    /// Executes the listing activity.
    /// </summary>
    public override void Execute()
    {
        StartActivity();

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        ShowCountdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        Console.WriteLine("Start listing items (type 'done' when finished):");

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done") break;
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items.");
        EndActivity();
    }
}