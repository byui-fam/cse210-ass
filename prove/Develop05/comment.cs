using System;

namespace Foundation1
{
    public class Comment
    {
        public string Username { get; set; }
        public string Text { get; set; }

        public Comment(string username, string text)
        {
            Username = username;
            Text = text;
        }

        public string GetCommentText()
        {
            return Text;
        }

        public string GetUsername()
        {
            return Username;
        }
    }
}
