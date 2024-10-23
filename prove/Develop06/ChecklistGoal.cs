using System;

/// <summary>
/// Represents a checklist goal that must be accomplished a certain number of times.
/// </summary>
public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;

    public ChecklistGoal(string name, string description, int points, int target)
        : base(name, description, points)
    {
        _target = target;
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _target)
        {
            _timesCompleted++;
            if (_timesCompleted == _target)
            {
                IsCompleted = true;
                return Points + 500; // Bonus for completing the goal
            }
            return Points;
        }
        return 0; // Goal already completed
    }

    public override string GetGoalDetails()
    {
        return IsCompleted ? $"[X] {Name}: {Description} (Completed {_timesCompleted}/{_target})"
                          : $"[ ] {Name}: {Description} (Completed {_timesCompleted}/{_target})";
    }
}