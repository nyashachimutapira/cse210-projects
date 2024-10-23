using System;

/// <summary>
/// Represents an eternal goal that can be recorded multiple times.
/// </summary>
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetGoalDetails()
    {
        return $"[ ] {Name}: {Description} (Eternal Goal)";
    }
}