using System;

namespace Library_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Librarian librarian = new Librarian();
            Library library = new Library();
            // Adding books to the library
            librarian.AddBook();
            librarian.AddBook();
            librarian.AddBook();
            librarian.DisplayAvailableBooks(library);
            librarian.BorrowBook(library, "9780451524935");
            // Display available books after borrowing
            librarian.DisplayAvailableBooks(library);
            // Returning a book
            librarian.ReturnBook(library, "9780451524935");
            // Display available books after returning
            librarian.DisplayAvailableBooks(library);
        }
    }
}
