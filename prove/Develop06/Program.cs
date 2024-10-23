using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Entry point for the Eternal Quest program.
/// </summary>
class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;
    const string filename = "GoalsData.txt";

    static void Main(string[] args)
    {
        LoadGoals();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Eternal Quest - Menu");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event for a goal");
            Console.WriteLine("3. Show all goals");
            Console.WriteLine("4. Show total points");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    Console.WriteLine($"Total Points: {totalPoints}");
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == "2")
        {
            goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == "3")
        {
            Console.Write("Enter target number of completions: ");
            int target = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, description, points, target));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    static void RecordEvent()
    {
        ShowGoals();
        Console.Write("Enter the index of the goal to record an event for: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            totalPoints += goals[index].RecordEvent();
            Console.WriteLine($"Recorded event for goal: {goals[index].Name}");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    static void ShowGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetGoalDetails()}");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetGoalDetails());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    static void LoadGoals()
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                // Logic to parse the line and recreate goal objects
                // You can implement the logic according to your goal details format
            }
        }
    }
}