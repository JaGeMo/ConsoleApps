using System.Collections.Generic;
namespace Console03
{   
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
    
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            return new List<Book> {
                new Book() {Title = "title1",Price = 7},
                new Book() {Title = "title2",Price = 10},
                new Book() {Title = "title3",Price = 8}
            };
        }
    }
}