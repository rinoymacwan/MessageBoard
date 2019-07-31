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
    public class IndexModel : PageModel
    {
        private readonly INoteData noteData;
        [TempData]
        public string Message { get; set; }

        public IEnumerable<Note> Notes { get; set; }


        public IndexModel(INoteData noteData)
        {
            this.noteData = noteData;
            
        }
        public void OnGet()
        {
            Notes = noteData.GetAll();
        }
    }
}
