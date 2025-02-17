using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EEFCore.ConsoleApp.Entities;

namespace OOP.EEFCore.ConsoleApp.DAL.mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);

            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(250);


            builder.HasData(
                new Book(){BookId = 1,Title = "Devlet"},
                new Book(){BookId = 2,Title = "Yoldaki İşaretler"},
                new Book(){BookId = 3,Title = "Yanlızlık Sözleri"}
            );
        }
    }
}
