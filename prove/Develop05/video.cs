using System;
using System.Collections.Generic;

namespace Foundation1
{
    // Class representing a video
    public class Video
    {
        // Attributes of the Video class
        public string Title { get; set; }
        public string Author { get; set; }
        public int Duration { get; set; } // Duration in seconds
        private List<Comment> Comments { get; set; }

        // Constructor to initialize the video with a title, author, and duration
        public Video(string title, string author, int duration)
        {
            Title = title;
            Author = author;
            Duration = duration;
            Comments = new List<Comment>();
        }

        // Method to add a comment to the video
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        // Method to get the number of comments on the video
        public int GetCommentCount()
        {
            return Comments.Count;
        }

        // Method to display video details
        public void GetDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Duration: {Duration} seconds");
            Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        }

        // Method to display all comments for the video
        public void DisplayComments()
        {
            Console.WriteLine("Comments:");
            foreach (var comment in Comments)
            {
                Console.WriteLine($"- {comment.GetUsername()}: {comment.GetCommentText()}");
            }
        }
    }
}
