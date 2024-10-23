using System;

/// <summary>
/// Represents a simple goal that can be marked complete.
/// </summary>
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        IsCompleted = true;
        return Points;
    }

    public override string GetGoalDetails()
    {
        return IsCompleted ? $"[X] {Name}: {Description} (Completed)" : $"[ ] {Name}: {Description} (Not Completed)";
    }
}