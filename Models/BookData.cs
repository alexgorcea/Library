namespace Gorcea_Alexandru_Lab2.Models
{
    public class BookData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Book> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}
