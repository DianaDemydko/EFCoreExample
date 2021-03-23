using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample
{
    public class MyContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("BookS");
        }
    }
}
