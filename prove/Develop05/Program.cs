using System;
using System.Threading;

// Base class for all activities
public abstract class MindfulnessActivity
{
    protected string name;
    protected string description;

    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public abstract void StartActivity();
    public abstract void EndActivity();
}

// Breathing Activity class
public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(string name, string description) : base(name, description) {}

    public override void StartActivity()
    {
        Console.WriteLine($"Starting {name}: {description}");
    }

    public override void EndActivity()
    {
        Console.WriteLine($"Ending {name}");
    }
}

// Reflection Activity class
public class ReflectionActivity : MindfulnessActivity
{
    public ReflectionActivity(string name, string description) : base(name, description) {}

    public override void StartActivity()
    {
        Console.WriteLine($"Starting {name}: {description}");
    }

    public override void EndActivity()
    {
        Console.WriteLine($"Ending {name}");
    }
}

// Listing Activity class
public class ListingActivity : MindfulnessActivity
{
    public ListingActivity(string name, string description) : base(name, description) {}

    public override void StartActivity()
    {
        Console.WriteLine($"Starting {name}: {description}");
    }

    public override void EndActivity()
    {
        Console.WriteLine($"Ending {name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the mindfulness activities
        MindfulnessActivity breathingActivity = new BreathingActivity("Breathing Exercise", "Focus on your breath");
        MindfulnessActivity reflectionActivity = new ReflectionActivity("Reflection Exercise", "Reflect on your thoughts");
        MindfulnessActivity listingActivity = new ListingActivity("Listing Exercise", "List things you are grateful for");

        // Start and end each activity with pauses and animations
        breathingActivity.StartActivity();
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.WriteLine("Let's take a deep breath in...");
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.WriteLine("...and slowly exhale.");
        Thread.Sleep(3000); // Pause for 3 seconds
        breathingActivity.EndActivity();

        reflectionActivity.StartActivity();
        for (int i = 3; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the number
        }
        Console.WriteLine("Reflect on your thoughts...");
        Thread.Sleep(5000); // Pause for 5 seconds
        reflectionActivity.EndActivity();

        listingActivity.StartActivity();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(10);
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Listing things you are grateful for...");
            Thread.Sleep(1000); // Pause for 1 second
        }
        listingActivity.EndActivity();
    }
}