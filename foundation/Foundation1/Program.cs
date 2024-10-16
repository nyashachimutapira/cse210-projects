using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    public List<Comment> Comments { get; } = new List<Comment>();

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
            Title = "Video 1",
            Author = "Author 1",
            LengthInSeconds = 300
        };
        video1.Comments.Add(new Comment { CommenterName = "User1", Text = "Great video!" });
        video1.Comments.Add(new Comment { CommenterName = "User2", Text = "Interesting content." });

        Video video2 = new Video
        {
            Title = "Video 2",
            Author = "Author 2",
            LengthInSeconds = 240
        };
        video2.Comments.Add(new Comment { CommenterName = "User3", Text = "Nice job!" });

        videos.Add(video1);
        videos.Add(video2);

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