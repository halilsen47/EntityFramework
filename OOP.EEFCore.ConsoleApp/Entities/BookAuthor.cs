using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EEFCore.ConsoleApp.Entities
{
    public class BookAuthor
    {
        public int BookAuthorId { get; set; }
        //Foregin Key
        public int BookId { get; set; }
        //Navigation Property
        public Book Book { get; set; }
        
        //Foregin Key
        public int AuthorId { get; set; }
        //Navigation Property
        public Author Author { get; set; }
    }
}
