using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NoticeBoard.Core;
using NoticeBoard.Data;

namespace NoticeBoard.Pages
{
    public struct tempNote
    {
        
        public int Id;
        public string Author;
        public string Content;
        public List<Comment> Comments;
        public DateTime DnT;
    }
    public class DetailsModel : PageModel
    {

        [BindProperty]
        public Comment comment { get; set; }
        public string Message { get; set; }
        [BindProperty]
        public Note note { get; set; }
        public INoteData noteData { get; set; }
        public int noteId { get; set; }
        public string temp { get; set; }
        public int Like { get; set; }
        public DetailsModel(INoteData noteData)
        {
            System.Diagnostics.Debug.WriteLine("AAAAA");
            this.noteData = noteData;
            System.Diagnostics.Debug.WriteLine("AAAAA");
        }
        public void OnGet(int noteId)
        {
            //System.Diagnostics.Debug.WriteLine("AAAAA");
            note = noteData.getById(noteId);
            noteId = note.Id;
            //System.Diagnostics.Debug.WriteLine(noteId);
            //System.Diagnostics.Debug.WriteLine("bbbbbbbbbbb");

        }
        public IActionResult OnPost(int noteId, Comment comment)
        {
            
            System.Diagnostics.Debug.WriteLine("XXXXXXXXX");
            noteData.AddComment(noteId, comment);
            TempData["Message"] = "Comment successfully added.";
            return RedirectToPage("./Index");
        }
        public void OnLike(object sender, EventArgs e)
        {
            
        }
    }
}