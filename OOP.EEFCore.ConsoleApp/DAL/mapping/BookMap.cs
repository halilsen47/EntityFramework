using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using OOP.EEFCore.ConsoleApp.Entities;

namespace OOP.EEFCore.ConsoleApp.DAL.mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            new DateTime();
            builder.HasKey(b => b.BookId);

            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(250);
            builder.Property(b => b.CreatedTime)
                .HasDefaultValueSql("getdate()");


            builder.HasData(
                new Book(){BookId = 1,Title = "Devlet",CategoryId = 3},
                new Book(){BookId = 2,Title = "Yoldaki İşaretler",CategoryId = 3},
                new Book(){BookId = 3,Title = "Yanlızlık Sözleri",CategoryId = 3}
            );

            builder.HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b=>b.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
