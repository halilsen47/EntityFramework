using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EEFCore.ConsoleApp.Entities;

namespace OOP.EEFCore.ConsoleApp.DAL.mapping
{
    public partial class BookMap
    {
        public class BookDetailMap : IEntityTypeConfiguration<BookDetail>
        {
            public void Configure(EntityTypeBuilder<BookDetail> builder)
            {
                //primary key
                builder.HasKey(bd => bd.BookDetailId);

                builder.Property(bd => bd.ISSN)
                    .IsRequired()
                    .HasDefaultValue("0000-0000-0000");

                builder.Property(bd => bd.Year)
                    .HasDefaultValue(DateTime.Now.Year);

                //Relation one-to-one
                builder.HasOne(bd => bd.Book)
                    .WithOne(b => b.BookDetail)
                    .HasForeignKey<BookDetail>(bd => bd.BookId)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }
    }
}
