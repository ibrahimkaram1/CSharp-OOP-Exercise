using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system1
{
    public class LibraryUser : User
    {
        private readonly object book;
        private LibraryCard libraryCard;
        private int bookCount;

        public LibraryUser(LibraryCard libraryCard)
        {
            this.libraryCard = libraryCard;
        }

        public void BorrowBook(Book book, Library library)
        {
            if (book == null)
            {
                Console.WriteLine("Invalid book details.");
                return;
            }

            if (library == null)
            {
                Console.WriteLine("Library reference is invalid.");
                return;
            }

            if (library.BorrowBook(book.ID))
            {
                Console.WriteLine($"{Name} borrowed the book {book.Title} succesfuly");
            }
            else
            {
                Console.WriteLine($"Sorry, the book '{book.Title}' could not be borrowed.");
            }
        }

        internal void AddBook(Book bOOK, Library library)
        {
            if (library.Add(bOOK)) 
            {
                bookCount++;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"\t\t\t\t == Book '{bOOK.Title}' added successfully ==");
                Console.ResetColor();
                Console.WriteLine("\n");

            }
        }
    }
}
