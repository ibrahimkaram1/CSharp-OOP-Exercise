using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system1
{
    public class Library : User
    {
        private Book[] books = new Book[100];
        public int currentBookCount = 0;
        private Book[] BorrowedBooks = new Book[50];
        private int currentBorrowedCount = 0;

        public bool Add(Book book)
        {
            if (book == null)
            {
                Console.WriteLine("Invalid book.");
                return false;
            }

            if (currentBookCount < books.Length)
            {
                books[currentBookCount] = book;
                currentBookCount++;
                return true;
            }
            else
            {
                Console.WriteLine("Library is full, cannot add more books.");
                return false;
            }
        }

        public bool Remove(Book book)
        {
            if (book == null) return false;

            for (int i = 0; i < currentBookCount; i++)
            {
                if (books[i] != null && books[i].Title == book.Title )
                {
                    for (int j = i; j < currentBookCount - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }
                    books[currentBookCount - 1] = null;
                    currentBookCount--;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write($"\t\t\t\t== Book '{book.Title}' removed successfully ==");
                    Console.ResetColor();
                    Console.WriteLine("\n");


                    return true;
                }
                else if (books[i] != null && books[i].Author == book.Author)
                {
                    for (int j = i; j < currentBookCount - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }
                    books[currentBookCount - 1] = null;
                    currentBookCount--;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write($"\t\t\t\t== Book by author '{book.Author}' removed successfully ==");
                    Console.ResetColor();
                    Console.WriteLine("\n");
                    return true;
                }
                else if (books[i] != null && books[i].ID == book.ID)
                {
                    for (int j = i; j < currentBookCount - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }
                    books[currentBookCount - 1] = null;
                    currentBookCount--;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write($"\t\t\t\t== Book with ID '{book.ID}' removed successfully ==");
                    Console.ResetColor();
                    Console.WriteLine("\n");

                    return true;
                }

            }
            Console.WriteLine("Book not found in the library.");
            return false;
        }

        public void DisplayBook()
        {
            if (currentBookCount == 0)
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            Console.WriteLine("Available books in the library:");
            for (int i = 0; i < currentBookCount; i++)
            {
                Book book = books[i];

                Console.WriteLine($"===================================");
                Console.WriteLine($"Book {i+1} => Title: {book.Title} => Author: {book.Author} => ISBN: {book.ID}");
               Console.WriteLine($"===================================");

            }
        }
        public bool BorrowBook(string bookId)
        {
            if (string.IsNullOrWhiteSpace(bookId))
            {
                Console.WriteLine("Invalid book ID.");
                return false;
            }

            for (int i = 0; i < currentBookCount; i++)
            {
                if (books[i] != null && books[i].ID == bookId)
                {
                    if (currentBorrowedCount >= BorrowedBooks.Length)
                    {
                        Console.WriteLine("Borrowed books limit reached.");
                        return false;
                    }

                    BorrowedBooks[currentBorrowedCount] = books[i];
                    currentBorrowedCount++;

                    for (int j = i; j < currentBookCount - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }
                    books[currentBookCount - 1] = null;
                    currentBookCount--;
                    Console.BackgroundColor = ConsoleColor.Magenta;

                    Console.Write($"\t\t\t\t== You have borrowed: {BorrowedBooks[currentBorrowedCount - 1].Title} ==");
                    Console.ResetColor();
                    Console.WriteLine("\n");
                    return true;
                }
            }

            Console.WriteLine("Book not found in the library.");
            return false;
        }


    }
}
   