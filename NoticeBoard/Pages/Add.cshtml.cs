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
    public class AddModel : PageModel
    {

        private INoteData noteData;
        [BindProperty]
        public Note n1 { get; set; }
        public string msg { get; set; }
        public AddModel(INoteData noteData)
        {
            this.noteData = noteData;
        }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            noteData.Add(n1);
            TempData["Message"] = "Message Added!";
            return RedirectToPage("./Index");
        }
    }
}