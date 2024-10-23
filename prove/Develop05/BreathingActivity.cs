using System.Threading;

/// <summary>
/// Represents a breathing activity.
/// </summary>
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    /// <summary>
    /// Executes the breathing activity.
    /// </summary>
    public override void Execute()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }

        EndActivity();
    }
}