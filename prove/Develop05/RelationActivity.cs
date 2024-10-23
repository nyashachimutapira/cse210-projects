using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// Represents a reflection activity.
/// </summary>
public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        Name = "Reflection Activity";
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    /// <summary>
    /// Executes the reflection activity.
    /// </summary>
    public override void Execute()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        ShowCountdown(5);

        while (DateTime.Now < endTime)
        {
            string question = questions[random.Next(questions.Count)];
            Console.WriteLine(question);
            ShowSpinner();
        }

        EndActivity();
    }

    /// <summary>
    /// Shows a spinner animation during pauses.
    /// </summary>
    private void ShowSpinner()
    {
        Console.Write("Thinking");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }
}