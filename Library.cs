using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    public class Library
    {
        static List<Book> books;
        public Library()
        {
            books = new List<Book>()
            {
                new Book{BookId=1,Title="How To Influence The People",AuthorName="Joshwa David",Gender='M',IsAvailable="Avilable"},
                new Book{BookId=2,Title="Selected Short Stories",AuthorName="Charles Dickens",Gender='M',IsAvailable="Not Available"},
                new Book{BookId=3,Title="ignite",AuthorName="John marry",Gender='F',IsAvailable="Avilable"},
                new Book{BookId=4,Title="Vip",AuthorName="brindha",Gender='F',IsAvailable="NotAvilable"},

            };
        }

            public void ViewAllBooks()
            {
            foreach (Book bo in books)
            {
                Console.WriteLine("Book ID: \t" + bo.BookId);
                Console.WriteLine("Author Name: \t" + bo.AuthorName);
                Console.WriteLine("Title: \t" + bo.Title);
                Console.WriteLine("Gender: \t" + bo.Gender);
                Console.WriteLine("Book Is Available or not : \t" + bo.IsAvailable);


            }
        }
        public void AddBook(Book book)
        {
           books.Add(book);
            Console.WriteLine("List after adding product");
            this.ViewAllBooks();
        }

        public Book SearchBookById(int bookId)
        {
            foreach (var book in books)
            {
                if (book.BookId == bookId)
                {
                    Console.WriteLine("Book is Available");
                    return book;
                }
            }

            return null; 
        }

    

            public Book SearchBookByTitle(string title)
             { 
             foreach (var book in books)
                  {
            if (string.Equals(book.Title, title, StringComparison.OrdinalIgnoreCase))
            {
                    Console.WriteLine("Book is Available");
                    return book;
            }
        }

        return null;
        }
    }
    }



