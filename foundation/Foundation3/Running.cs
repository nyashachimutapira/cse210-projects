using System;

namespace FitnessTracker
{
    /// <summary>
    /// Represents a running activity.
    /// </summary>
    public class Running : Activity
    {
        private double _distance; // Distance in miles
        private double Duration;

        public Running(DateTime date, int duration, double distance) : base(date, duration)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return _distance / Duration * 60; // Speed in mph
        }

        public override double GetPace()
        {
            return Duration / _distance; // Pace in minutes per mile
        }

        public override string GetSummary()
        {
            return base.GetSummary() + $" Running - Distance: {GetDistance()} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min/mile";
        }
    }
}