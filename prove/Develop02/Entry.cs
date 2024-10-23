using System;

namespace JournalApp
{
    /// <summary>
    /// Represents a journal entry.
    /// </summary>
    public class Entry
    {
        public string Date { get; private set; }
        public string Prompt { get; private set; }
        public string Response { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Entry class.
        /// </summary>
        /// <param name="date">The date of the entry.</param>
        /// <param name="prompt">The prompt for the entry.</param>
        /// <param name="response">The user's response.</param>
        public Entry(string date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }

        /// <summary>
        /// Returns a formatted string representation of the entry.
        /// </summary>
        public override string ToString()
        {
            return $"{Date} | Prompt: {Prompt} | Response: {Response}";
        }
    }
}