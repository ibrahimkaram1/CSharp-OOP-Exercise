using System;

namespace Library_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Librarian librarian = new Librarian();
            Library library = new Library();
            librarian.AddBook();
            librarian.AddBook();
            librarian.AddBook();
            librarian.DisplayAvailableBooks(library);
            librarian.BorrowBook(library, "9780451524935");
            librarian.DisplayAvailableBooks(library);
            librarian.ReturnBook(library, "9780451524935");
            librarian.DisplayAvailableBooks(library);
        }
    }
}
