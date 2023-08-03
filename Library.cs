using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08___Library
{
    internal class Library : iLibrary
    {
        private Dictionary<string, Book> Storage;

        public int Count { get; set; }
        public Library()
        {
            Storage = new Dictionary<string, Book>();
            Book Book1 = new Book("Dream Bigger", "Marshawn Evans Daniels");
            Storage.Add(Book1.Title, Book1);

            Book Book2 = new Book("The Slight Edge", "Jeff Olson");
            Storage.Add(Book2.Title, Book2);

            Book Book3 = new Book("Unapologetically Ambitious", "Shelley Archambeau");
            Storage.Add(Book3.Title, Book3);
        }

        public void Add(string title, string author)
        {
            Book newBook = new Book(title, author);

            Storage.Add(newBook.Title, newBook);
            var result = Storage.Keys;

        }

        // the method will handle iterating throught the individual data elemnts in the library object

        IEnumerator IEnumerable.GetEnumerator()
        {
            // call the generic version of the method
            return this.GetEnumerator();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            var result = Storage.Values;
            foreach (Book book in result)
            {
                yield return book;
            }
        }


        public Book Borrow(string title)
        {
            Book returnedBook = Storage.GetValueOrDefault(title);
            Storage.Remove(returnedBook.Title);
            return returnedBook;
        }
        public void Return(Book book)
        {
            Storage.Add(book.Title, book);
        }



        public Book Search(string title)
        {
            // if there is no key in database with search criteria, return null
            if (Storage.ContainsKey(title)) // ContainsKey method returns true or false
            {
                return Storage[title];
            }
            return null;
        }

        public void ViewAllBooks()
        {
            var keys = Storage.Keys;
            for (int i = 0; i < keys.Count; i++)
            {
                string key = keys.ElementAt(i);
                Console.WriteLine(key);

            }

        }


    }
}
