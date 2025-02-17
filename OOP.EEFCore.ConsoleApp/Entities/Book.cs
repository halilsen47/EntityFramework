using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EEFCore.ConsoleApp.Entities
{
    public class Book
    {

        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } // Navigation Property

    }
}
