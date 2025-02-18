using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OOP.EEFCore.ConsoleApp.DAL.mapping;
using OOP.EEFCore.ConsoleApp.Entities;
using static OOP.EEFCore.ConsoleApp.DAL.mapping.BookMap;

namespace OOP.EEFCore.ConsoleApp.DAL
{
    public class BookAppDbContext : DbContext
    {
        public DbSet<Book> Books{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; } 
        public DbSet<Author> Authors{ get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= BookAppDb;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    modelBuilder.Entity<Book>()
            //        .HasKey(b => b.BookId);
            //    modelBuilder.Entity<Book>()
            //        .Property(b => b.Title)
            //        .IsRequired()
            //        .HasMaxLength(150);

            modelBuilder.ApplyConfiguration(new BookMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new BookDetailMap());
            modelBuilder.ApplyConfiguration(new AuthorMap());
            modelBuilder.ApplyConfiguration(new BookAuthorMap());
        
        }

       
    }
}
