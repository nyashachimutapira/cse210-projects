using System;
using System.Collections.Generic;

namespace FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold activities
            List<Activity> activities = new List<Activity>();

            // Add activities to the list
            activities.Add(new Running(new DateTime(2023, 11, 3), 30, 3.0));
            activities.Add(new Cycling(new DateTime(2023, 11, 4), 45, 15.0));
            activities.Add(new Swimming(new DateTime(2023, 11, 5), 30, 20));

            // Iterate through the list and display the summary for each activity
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}