using Microsoft.EntityFrameworkCore;
using NoticeBoard.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoticeBoard.Data
{
    public class NoticeBoardDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public NoticeBoardDbContext(DbContextOptions<NoticeBoardDbContext> options)
            : base(options)
        {

        }
    }
}
