using System;

namespace Library_management_system1
{
    public abstract class User
    {
        public string Name { get; set; }

        public void DisplayBook(Library library)
        {
            if (library == null)
            {
                Console.WriteLine("No library specified.");
                return;
            }

            library.DisplayBook();
        }
    }
}
