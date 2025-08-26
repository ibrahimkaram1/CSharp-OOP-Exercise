using System;

namespace Library_management_system1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t====================================");
            Console.WriteLine("\t\t\t\t=======Welcome to the library=======");
            Console.WriteLine("\t\t\t\t====================================");

            Console.WriteLine("Enter you are L / R :");
            char userType = Console.ReadLine().ToUpper()[0];

            Library library = new Library();

            if (userType == 'L')
            {

                Console.Write("Welcome librarian, enter your name:");
            }
            else if (userType == 'R')
            {
                Console.Write("Welcome regular user,");
            }
            ;
            
                while (true)
                {
                    if (userType == 'L')
                    {
                    string librarianName = Console.ReadLine();

                        Librarian l1 = new Librarian(librarianName);
                        Console.WriteLine($"=> Welcome << {l1.Name} >>");
                        Console.WriteLine("Please choose to AddBook (A) / Remove Book (R) / Display Book (D):");

                        char librarianChoice = Console.ReadLine().ToUpper()[0];
                        switch (librarianChoice)
                        {
                            case 'A':
                                Console.WriteLine("Enter book title:");
                                string title = Console.ReadLine();
                                Console.WriteLine("Enter book author:");
                                string author = Console.ReadLine();
                                Console.WriteLine("Enter book ID:");
                                string isbn = Console.ReadLine();
                                Book BOOK = new Book
                                {
                                    Title = title
                                    ,
                                    Author = author
                                    ,
                                    ID = isbn

                                };
                                l1.AddBook(BOOK, library);
                                break;

                            case 'R':
                                Console.WriteLine("Choose delete option: ");
                                Console.WriteLine("1 - Delete by Title");
                                Console.WriteLine("2 - Delete by Author");
                                Console.WriteLine("3 - Delete by ID");
                                string choice = Console.ReadLine();

                                if (choice == "1")
                                {
                                    Console.Write("Enter book title to remove: ");
                                    title = Console.ReadLine();
                                    BOOK = new Book { Title = title };
                                    l1.RemoveBook(BOOK, library);
                                }
                                else if (choice == "2")
                                {
                                    Console.Write("Enter book author to remove: ");
                                    author = Console.ReadLine();
                                    BOOK = new Book { Author = author };
                                    l1.RemoveBook(BOOK, library);
                                }
                                else if (choice == "3")
                                {
                                    Console.Write("Enter book ISBN to remove: ");
                                    isbn = Console.ReadLine();
                                    BOOK = new Book { ID = isbn };
                                    l1.RemoveBook(BOOK, library);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid choice.");
                                }
                                break;

                            case 'D':
                                library.DisplayBook();
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please enter A, R, or D.");
                                break;
                        }
                 }   

                     if (userType == 'R')
                    {
                        Console.WriteLine("Enter your name:");
                        string userName = Console.ReadLine();

                        Console.WriteLine("Enter your card number:");
                        string cardNumber = Console.ReadLine();

                        Console.WriteLine("Enter expiration date (MM/DD/YYYY):");
                        DateTime expirationDate;
                        while (!DateTime.TryParse(Console.ReadLine(), out expirationDate))
                        {
                            Console.WriteLine("Invalid date format. Please enter again (MM/DD/YYYY):");
                        }

                        LibraryCard libraryCard = new LibraryCard(cardNumber, userName, expirationDate);
                        LibraryUser libraryUser = new LibraryUser(libraryCard) { Name = userName };

                        if (libraryCard.IsExpired())
                        {
                            Console.WriteLine("Your library card has expired. Please renew it before borrowing books.");
                            return;
                        }

                        Console.WriteLine($"Welcome {libraryUser.Name}!");
                        Console.WriteLine("Choose: Add Books (A) Display Books (D) / Borrow Book (B):");
                        char choice = Console.ReadLine().ToUpper()[0];

                        switch (choice)
                        {
                            case 'A':
                                Console.WriteLine("Enter book title:");
                                string title = Console.ReadLine();
                                Console.WriteLine("Enter book author:");
                                string author = Console.ReadLine();
                                Console.WriteLine("Enter book ID:");
                                string isbn = Console.ReadLine();
                                Book BOOK = new Book
                                {
                                    Title = title
                                    ,
                                    Author = author
                                    ,
                                    ID = isbn

                                };
                                libraryUser.AddBook(BOOK, library);
                                break;
                            case 'D':
                                libraryUser.DisplayBook(library);
                                break;

                            case 'B':
                                Console.WriteLine("Enter book ID to borrow:");
                                string bookId = Console.ReadLine();
                                Book tempBook = new Book { ID = bookId };
                                libraryUser.BorrowBook(tempBook, library);
                                break;

                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'L' for Librarian or 'R' for Regular User.");
                    }
                }
            }

        }

    }
