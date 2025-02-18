using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.Json;
using OOP.EEFCore.ConsoleApp.Entities;

namespace OOP.EEFCore.ConsoleApp.DAL.mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);
            
            builder.Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(200);
            
            builder.Property(c => c.Description)
                .HasDefaultValue("No İnfo");

 


        }
    }
}
