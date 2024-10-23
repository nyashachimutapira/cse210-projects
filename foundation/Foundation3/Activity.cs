using System;

namespace FitnessTracker
{
    /// <summary>
    /// Represents a base class for an exercise activity.
    /// </summary>
    public abstract class Activity
    {
        private DateTime _date;
        private int _duration; // Duration in minutes

        /// <summary>
        /// Initializes a new instance of the <see cref="Activity"/> class.
        /// </summary>
        /// <param name="date">The date of the activity.</param>
        /// <param name="duration">The duration of the activity in minutes.</param>
        protected Activity(DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        /// <summary>
        /// Gets the distance of the activity.
        /// </summary>
        /// <returns>The distance covered in the activity.</returns>
        public abstract double GetDistance();

        /// <summary>
        /// Gets the speed of the activity.
        /// </summary>
        /// <returns>The speed of the activity.</returns>
        public abstract double GetSpeed();

        /// <summary>
        /// Gets the pace of the activity.
        /// </summary>
        /// <returns>The pace of the activity.</returns>
        public abstract double GetPace();

        /// <summary>
        /// Gets a summary of the activity.
        /// </summary>
        /// <returns>A string summary of the activity.</returns>
        public virtual string GetSummary()
        {
            return $"{_date:dd MMM yyyy} - Duration: {_duration} min";
        }
    }
}