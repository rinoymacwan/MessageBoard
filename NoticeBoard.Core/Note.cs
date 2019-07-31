using System;
using System.Collections.Generic;
using System.Text;

namespace NoticeBoard.Core
{
    public class Note
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime DnT { get; set; }
        public List<Comment> Comments;
        public int Likes { get; set; }
        public static int ongoing = 0;
        public Note()
        {
            this.Id = ++Note.ongoing;
            Comments = new List<Comment>();
            this.DnT = DateTime.Now;
            System.Diagnostics.Debug.WriteLine($"{Author} with id:{Id}");
            this.Likes = 0;
        }
        public Note(string Content, string Author)
        {
            this.Id = ++Note.ongoing;
            this.Content = Content;
            this.Author = Author;
            this.DnT = DateTime.Now;
            Comments = new List<Comment>();
            System.Diagnostics.Debug.WriteLine($"{Author} with id:{Id}");
            this.Likes = 0;
        }
    }
}
