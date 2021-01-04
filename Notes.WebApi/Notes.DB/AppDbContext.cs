using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.DB
{
    
        public class AppDbContext : DbContext
        {
            public DbSet<Note> Notes { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=DESKTOP-9HEQTO5\SQLEXPRESS;Database=Notes;uid=sa; pwd=123");
            }
        }
    
}
