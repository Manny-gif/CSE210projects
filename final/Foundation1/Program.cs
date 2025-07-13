using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        
        Video video1 = new Video("Understanding Encapsulation", "BYU-I CS Dept", 300);
        video1.AddComment(new Comment("John", "Great explanation!"));
        video1.AddComment(new Comment("Sarah", "Helped me a lot, thanks."));
        video1.AddComment(new Comment("Alex", "Please do one on inheritance next."));
        videos.Add(video1);

        
        Video video2 = new Video("Object-Oriented Programming", "Tech Explained", 450);
        video2.AddComment(new Comment("Liam", "Clear and easy to follow."));
        video2.AddComment(new Comment("Emma", "What language is this in?"));
        video2.AddComment(new Comment("Noah", "Awesome content!"));
        videos.Add(video2);

    
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}
