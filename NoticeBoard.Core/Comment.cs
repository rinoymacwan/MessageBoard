using System;

namespace NoticeBoard.Core
{
    public class Comment
    {
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime DnT { get; set; }

        public Comment()
        {
            this.DnT = DateTime.Now;
        }
        public Comment(string Content, string Author)
        {
            this.Content = Content;
            this.Author = Author;
            this.DnT = DateTime.Now;
        }
    }
}