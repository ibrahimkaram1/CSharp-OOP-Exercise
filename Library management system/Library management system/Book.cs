using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsValid { get; internal set; }

        public Book(string title, string author, string isbn, int publicationYear)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            IsAvailable = true;
        }
        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"{Title} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{Title} is currently not available.");
            }
        }
        public void Return()
        {
            IsAvailable = true;
            Console.WriteLine($"{Title} has been returned.");
        }
        public override string ToString()
        {
            return $"{Title} by {Author}, ISBN: {ISBN}, Published: {PublicationYear}, Available: {IsAvailable}";
        }

        internal void DisplayInfo()
        {
            //throw new NotImplementedException();
        }
    }
}
