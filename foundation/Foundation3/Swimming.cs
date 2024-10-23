using System;

namespace FitnessTracker
{
    /// <summary>
    /// Represents a swimming activity.
    /// </summary>
    public class Swimming : Activity
    {
        private int _laps; // Number of laps

        public double Duration { get; private set; }

        public Swimming(DateTime date, int duration, int laps) : base(date, duration)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * 50 / 1000.0; // Distance in kilometers
        }

        public override double GetSpeed()
        {
            return GetDistance() / Duration * 60; // Speed in kph
        }

        public override double GetPace()
        {
            return Duration / GetDistance(); // Pace in minutes per kilometer
        }

        public override string GetSummary()
        {
            return base.GetSummary() + $" Swimming - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min/km";
        }
    }
}