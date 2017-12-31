
using System;
using System.Collections.Generic;

namespace Console01
{
    class Program
    {
        static void Main(string[] args)
        {

            var book1 = new Book() { Name = "Book1", Author = "Author1" };
            var book2 = new Book() { Name = "Book2", Author = "Author2" };

            var bookList = new GenericList<Book>();
            bookList.Add(book1);
            bookList.Add(book2);

            var bookDictionary = new GenericDictionary<int,Book>();
            bookDictionary.Add(1,book1);
            bookDictionary.Add(2,book2);

            var newGenericBookList = new List<Book>();
            newGenericBookList.Add(book1);
            newGenericBookList.Add(book2);

            var nextGenericCollection = new Dictionary<int,Book>();
            nextGenericCollection.Add(1,book1);
            nextGenericCollection.Add(2,book2);
            
            var compareStrings = new Comparison<List<string>>();
            string result = compareStrings.Compare("string1","string2");

            var nullableTest = new Nullable<int>();
            int test = nullableTest.GetValueOrDefault();

            Console.ReadLine();
        }
    }
}
