using System;
using System.Threading;

/// <summary>
/// Base class for all mindfulness activities.
/// </summary>
public abstract class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    /// <summary>
    /// Starts the activity with a common starting message.
    /// </summary>
    public void StartActivity()
    {
        Console.WriteLine($"--- {Name} ---");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        ShowCountdown(3);
    }

    /// <summary>
    /// Ends the activity with a common ending message.
    /// </summary>
    public void EndActivity()
    {
        Console.WriteLine("Good job! You have completed this activity.");
        ShowCountdown(3);
        Console.WriteLine($"You spent {Duration} seconds on this activity.");
    }

    /// <summary>
    /// Shows a countdown for the given duration.
    /// </summary>
    /// <param name="seconds">The number of seconds for the countdown.</param>
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    /// <summary>
    /// Abstract method to be implemented by concrete activity classes.
    /// </summary>
    public abstract void Execute();
}