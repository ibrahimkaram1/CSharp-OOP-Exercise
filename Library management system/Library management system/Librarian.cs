using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class Librarian : Library
    {
        public Librarian() { }
        public void AddBook()
        {
            Book book = null;
            Library library = new Library();
            Console.WriteLine("Enter book details:");
             Console.WriteLine("Title:");
            string title = Console.ReadLine();
            book.Title = title;
            Console.WriteLine("Author:");
            string author = Console.ReadLine();
            book.Author = author;
            Console.WriteLine("ISBN:");
            string isbn = Console.ReadLine();
            book.ISBN = isbn;
            Console.WriteLine("Publication Year:");
            int publicationYear = int.Parse(Console.ReadLine());
            book.PublicationYear = publicationYear;
            book = new Book(title, author, isbn, publicationYear);

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn) || publicationYear <= 0)
            {
                Console.WriteLine("Invalid book details. Please try again.");
              
            }
            else if (Library.IsBookExists(isbn))
            {
                Console.WriteLine("Book with this ISBN already exists.");
                return;
            }
            else if (book.IsValid)
            {
                Console.WriteLine($"Book '{book.Title}' by {book.Author} added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid book details. Please try again.");
                return;
            }

                 Book[] Books = new Book[100];
        book.IsAvailable = true;
            library.AddBook(book);
            // Assuming the library has a method to add books
            Books[0] = book; // Add the book to the library's collection
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }
        public void BorrowBook(Library library, string isbn)
        {
            library.BorrowBook(isbn);
        }
        public void ReturnBook(Library library, string isbn)
        {
            library.ReturnBook(isbn);
        }
        public void DisplayAvailableBooks(Library library)
        {
            library.DisplayAvailableBooks();
        }
        public void DisplayBorrowedBooks(Library library)
        {
            library.DisplayBorrowedBooks();
        }
        public void DisplayAllBooks(Library library)
        {
            library.DisplayAllBooks();
        }

        public void SearchBook(Library library, string title)
        {
            library.SearchBook(title);

        }
        public void SearchBookByAuthor(Library library, string author)
        {
            library.SearchBookByAuthor(author);
        }
        public void SearchBookByISBN(Library library, string isbn)
        {
            library.SearchBookByISBN(isbn);
        }
        public void SearchBookByCategory(Library library, string category)
        {
            library.SearchBookByCategory(category);
        }
    }  }
