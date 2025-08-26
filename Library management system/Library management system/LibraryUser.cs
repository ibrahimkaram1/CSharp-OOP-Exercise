using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class LibraryUser : Library
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public LibraryCard Card { get; set; }

        public LibraryUser(string name, string email, string phoneNumber, LibraryCard card)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Card = card;
        }
        // Method to borrow a book
        //public void BorrowBook(Library library, Book book)
        //{

        //    object borrowedBook = Book;
        //    if (!Book.book && book.IsValid)
        //    {
        //        Console.WriteLine($"{Name} borrowed '{book.Title}' from the library.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Sorry, '{book.Title}' is not available for borrowing.");
        //    }
        //}
        // Method to return a book
        public void ReturnBook(Library library, Book book)
        {
            Console.WriteLine($"{Name} returned '{book.Title}' to the library.");
        }
    }
}
