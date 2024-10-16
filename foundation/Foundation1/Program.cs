using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public List<Comment> Comments { get; set; }

    public Video()
    {
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }
}

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video
        {
            Title = "Product X Review",
            Author = "Reviewer123",
            LengthInSeconds = 480
        };
        video1.Comments.Add(new Comment { CommenterName = "User1", Text = "Interesting video!" });
        video1.Comments.Add(new Comment { CommenterName = "User2", Text = "I learned a lot." });
        video1.Comments.Add(new Comment { CommenterName = "User3", Text = "Great insights!" });

        // Create and add more videos with comments here

        videos.Add(video1);

        // Add other videos to the list here

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}