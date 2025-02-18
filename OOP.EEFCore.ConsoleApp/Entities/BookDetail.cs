namespace OOP.EEFCore.ConsoleApp.Entities
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }

        //Foregin Key - unique
        public int BookId { get; set; }
        //Navigation property
        public Book Book{ get; set; }
        public string ISSN { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
    }
}
