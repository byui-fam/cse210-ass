using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Understanding Abstraction in C#", "Jane Doe", 300);
        video1.AddComment(new Comment("Abiodun", "Great explanation!"));
        video1.AddComment(new Comment("Abosede", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Abidemi", "Can you explain encapsulation next?"));
        videos.Add(video1);

        Video video2 = new Video("C# Classes and Objects", "John Smith", 420);
        video2.AddComment(new Comment("Dayo", "This is exactly what I needed."));
        video2.AddComment(new Comment("Enyan", "Clear and concise. Good job!"));
        video2.AddComment(new Comment("Fola", "Thanks for sharing this tutorial."));
        videos.Add(video2);

        Video video3 = new Video("Introduction to OOP", "Alice Johnson", 250);
        video3.AddComment(new Comment("Grace", "Very well structured."));
        video3.AddComment(new Comment("Tope", "Helped me a lot with my project."));
        video3.AddComment(new Comment("Ire", "Looking forward to more videos like this."));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}
