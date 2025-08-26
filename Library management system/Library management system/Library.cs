using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class Library
    { 
 
      private  Book[] borrowbooks= new Book[100];

        public object Books { get; internal set; }
        public object Book { get; internal set; }

        public void AddBook(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    books[i] = book;
                    Console.WriteLine($"Book '{book.Title}' added to the library.");
                    return;
                }
            }
            Console.WriteLine("Library is full, cannot add more books.");
        }
        public void BorrowBook(string isbn)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null && books[i].ISBN == isbn && books[i].IsAvailable)
                {
                    books[i].Borrow();
                    borrowbooks[i] = books[i];
                    return;
                }
            }
            Console.WriteLine("Book not found or not available for borrowing.");
        }

      
        public void ReturnBook(string isbn)
        {
            for (int i = 0; i < borrowbooks.Length; i++)
            {
                if (borrowbooks[i] != null && borrowbooks[i].ISBN == isbn)
                {
                    borrowbooks[i].Return();
                    borrowbooks[i] = null; // Remove from borrowed books
                    return;
                }
            }
            Console.WriteLine("Book not found in borrowed list.");
        }
        public void DisplayAvailableBooks()
        {
            Console.WriteLine("Available Books:");
            foreach (var book in books)
            {
                if (book != null && book.IsAvailable)
                {
                    book.DisplayInfo();
                }
            }
        }
        public void DisplayBorrowedBooks()
        {
            Console.WriteLine("Borrowed Books:");
            foreach (var book in borrowbooks)
            {
                if (book != null)
                {
                    book.DisplayInfo();
                }
            }
        }
        public void DisplayAllBooks()
        {
            Console.WriteLine("All Books in Library:");
            foreach (var book in books)
            {
                if (book != null)
                {
                    book.DisplayInfo();
                }
            }
        }
        public void SearchBookByTitle(string title)
        {
            Console.WriteLine($"Searching for books with title '{title}':");
            foreach (var book in books)
            {
                if (book != null && book.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                {
                    book.DisplayInfo();
                }
            }
        }
        public void SearchBookByAuthor(string author)
        {
            Console.WriteLine($"Searching for books by author '{author}':");
            foreach (var book in books)
            {
                if (book != null && book.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
                {
                    book.DisplayInfo();
                }
            }
        }
        public void SearchBookByISBN(string isbn)
        {
            Console.WriteLine($"Searching for book with ISBN '{isbn}':");
            foreach (var book in books)
            {
                if (book != null && book.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase))
                {
                    book.DisplayInfo();
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }
        public void SearchBookByCategory(string category)
        {
            Console.WriteLine($"Searching for books in category '{category}':");
            foreach (var book in books)
            {
                if (book != null && book.Title.Contains(category, StringComparison.OrdinalIgnoreCase)) // Assuming category is part of the title
                {
                    book.DisplayInfo();
                }
            }
        }
        public void RemoveBook(string isbn)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null && books[i].ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase))
                {
                    books[i] = null; // Remove the book
                    Console.WriteLine($"Book with ISBN '{isbn}' has been removed from the library.");
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }
        public void ClearLibrary()
        {
            books = new Book[100]; // Reset the library
            borrowbooks = new Book[100]; // Reset borrowed books
            Console.WriteLine("Library has been cleared.");
        }

        internal void SearchBook(string title)
        {
            Console.WriteLine($"Searching for books with title '{title}':");
        }

        internal static bool IsBookExists(string isbn)
        {
           try
                {
                // Check if a book with the given ISBN already exists in the library
                // This is a placeholder implementation; actual implementation would check against the library's book collection
                return false; // Assuming no book exists with the given ISBN for now
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking book existence: {ex.Message}");
                return false;
            }
            //throw new NotImplementedException();
        }
    }
     
}
