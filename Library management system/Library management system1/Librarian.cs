using System;

namespace Library_management_system1
{
    public class Librarian : User
    {
        public int bookCount = 0;
        public int EmployeeId { get; set; }

        public Librarian(string name)
        {
            Name = name;
        }

        public void AddBook(Book book, Library library)
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

            if (library.Add(book)) // نخلي Add ترجع bool لو الكتاب اتضاف فعلاً
            {
                bookCount++;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"\t\t\t\t == Book '{book.Title}' added successfully ==");
                Console.ResetColor();

            }
            else
            {
                Console.WriteLine("Book could not be added (maybe library is full).");
            }
        }

        public void RemoveBook(Book book, Library library)
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

            if (library.Remove(book)) 
            {
                bookCount--;
            

            }
           

            else
            {
                Console.WriteLine("Book not found in the library.");
            }
        }
    }
}
