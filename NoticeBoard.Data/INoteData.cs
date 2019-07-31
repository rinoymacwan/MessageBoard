using NoticeBoard.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NoticeBoard.Data
{
    public interface INoteData
    {
        IEnumerable<Note> GetAll();
        Note getById(int id);
        Note Add(Note note);
        void AddComment(int noteId, Comment comment);
    }

    public class InMemoryNoteData: INoteData
    {
        List<Note> Notes;
        public InMemoryNoteData()
        {
            Notes = new List<Note>()
            {
                new Note("This is my first note.","Rinoy"),
                new Note("This is the second note.","KSHMR")
                
            };
            

        }

        public IEnumerable<Note> GetAll()
        {
            return Notes.OrderBy(n => n.DnT);
        }

        public Note getById(int id)
        {
            return Notes.SingleOrDefault(k => k.Id == id);
        }
        public Note Add(Note newNote)
        {
            Notes.Add(newNote);
            return newNote;
        }
        public void AddComment(int noteId, Comment comment)
        {
            getById(noteId).Comments.Add(comment);
            
        }
    }
}
