using System;

namespace Console03
{
    class Program
    {
        static void Main(string[] args)
        {   
            // args =>  expression .. 'goes to'
            
            Func<int,int> tfunc1 = x => x*x;
            
            System.Console.WriteLine(tfunc1(10));

            // test book list the old fashioned way
            var bookList = new BookRepository().GetAllBooks();

            var cheapBookList = bookList.FindAll(cheapBook);

            foreach(var book in cheapBookList)
            {
                Console.WriteLine(book.Title);
            }

            // test book list the new way
            var cheapBookListNew = bookList.FindAll(book => book.Price < 10);
            foreach (var book in cheapBookListNew)
            {
                Console.WriteLine(book.Title);

            }
        }
    
        static bool cheapBook(Book book)
        {
            return book.Price < 10;
        }
    
    }
}
