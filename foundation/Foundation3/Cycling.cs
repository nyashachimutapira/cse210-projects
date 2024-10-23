using System;

namespace FitnessTracker
{
    /// <summary>
    /// Represents a cycling activity.
    /// </summary>
    public class Cycling : Activity
    {
        private double _speed; // Speed in mph
        private double Duration;

        public Cycling(DateTime date, int duration, double speed) : base(date, duration)
        {
            _speed = speed;
        }

        public override double GetDistance()
        {
            return _speed * Duration / 60; // Distance in miles
        }

        public override double GetSpeed()
        {
            return _speed; // Speed in mph
        }

        public override double GetPace()
        {
            return 60 / _speed; // Pace in minutes per mile
        }

        public override string GetSummary()
        {
            return base.GetSummary() + $" Cycling - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min/mile";
        }
    }
}