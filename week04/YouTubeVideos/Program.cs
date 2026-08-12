// Week4 YouTube Video Program - CSE210hw2026
// This program creates a list of YouTube videos, each with a title, author, length, and comments. It then displays the information for each video along with its comments.
// I have put comments which serves as my markings and guide.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1: Bleach reference
        Video v1 = new Video("Bleach Anime Review", "OtakuSensei", 720);
        v1.AddComment(new Comment("Ichigo", "Bankai scene was epic!"));
        v1.AddComment(new Comment("Rukia", "Loved the character growth."));
        v1.AddComment(new Comment("Uryu", "Animation could be better, but story is solid."));
        videos.Add(v1);

        // Video 2: Gaming Laptop Review
        Video v2 = new Video("Gaming Laptop Review", "TechGuy", 600);
        v2.AddComment(new Comment("Alice", "Great review, helped me a lot!"));
        v2.AddComment(new Comment("Bob", "You should test battery life next time."));
        v2.AddComment(new Comment("Charlie", "Cool video, thanks!"));
        videos.Add(v2);

        // Video 3: Basketball Highlight
        Video v3 = new Video("Basketball Highlights", "SportsZone", 420);
        v3.AddComment(new Comment("George", "Amazing dunk at 2:15!"));
        v3.AddComment(new Comment("Hannah", "Go team!"));
        v3.AddComment(new Comment("Ian", "Replay quality is awesome."));
        videos.Add(v3);

        // Display all videos
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
