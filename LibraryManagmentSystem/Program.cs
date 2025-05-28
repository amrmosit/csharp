// You will create a simple library management system that stores up to five book titles 
//using string variables. The system will allow users to add new books, remove a book,
// and display the list of available books.

using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        while (true)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Display Books");
            Console.WriteLine("4. Search Book");
            Console.WriteLine("5. Borrow Book");
            Console.WriteLine("6. Check In Book");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter book title: ");
                    string? titleToAdd = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(titleToAdd))
                    {
                        AddBook(titleToAdd, books);
                    }
                    else
                    {
                        Console.WriteLine("Book title cannot be empty.");
                    }
                    break;
                case "2":
                    Console.Write("Enter book number to remove: ");
                    string? bookNumber = Console.ReadLine();
                    if (bookNumber != null)
                    {
                        RemoveBook(bookNumber, books);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Book number cannot be null.");
                    }
                    break;
                case "3":
                    DisplayBooks(books);
                    break;
                case "4":
                    Console.Write("Enter book title to search: ");
                    string? booktitle = Console.ReadLine();
                    if (booktitle != null)
                    {
                        SearchBook(booktitle, books);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Book number cannot be null.");
                    }
                    break;
                case "5":
                    Console.Write("Enter book title to borrow: ");
                    string? titleToBorrow = Console.ReadLine();
                    if (titleToBorrow != null)
                    {
                        BorrowBook(titleToBorrow, books);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Book title cannot be null.");
                    }
                    break;
                case "6":
                    Console.Write("Enter book title to check in: ");
                    string? titleToCheckIn = Console.ReadLine();
                    if (titleToCheckIn != null)
                    {
                        CheckInBook(titleToCheckIn, books);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Book title cannot be null.");
                    }
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
    public static void AddBook(string title, List<Book> books)
    {
        if (books.Count < 5)
        {
            books.Add(new Book(title));
            Console.WriteLine($"Book '{title}' added successfully.");
        }
        else
        {
            Console.WriteLine("Cannot add more than 5 books.");
        }
    }
    public static void RemoveBook(string bookNumber, List<Book> books)
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available to remove.");
        }
        else if (books.Count > 0)
        {
            DisplayBooks(books);
            Console.WriteLine("Enter book number to remove:");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= books.Count)
            {
                books.RemoveAt(index - 1);
                Console.WriteLine($"Book removed successfully.");
                DisplayBooks(books);
            }
            else
            {
                Console.WriteLine("Invalid book number.");
            }
        }

    }
    public static void DisplayBooks(List<Book> books)
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
        }
        else
        {
            Console.WriteLine("Books in the library:");
            for (int i = 0; i < books.Count; i++)
            {
                string status = books[i].IsCheckedOut ? "Checked Out" : "Available";
                Console.WriteLine($"{i + 1}. {books[i].Title} - {status}");
            }
        }
    }

    // Add a Search Feature
    // Prompt the user to input a book title to search for.
    // If the book is found, display a message indicating it is available.
    // If the book is not found, display a message that it’s not in the collection.
    public static void SearchBook(string title, List<Book> books)
    {
        var foundBooks = books
            .Where(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (foundBooks.Count > 0)
        {
            foreach (var book in foundBooks)
            {
                string status = book.IsCheckedOut ? "Checked Out" : "Available";
                Console.WriteLine($"Book '{book.Title}' is {status}.");
            }
        }
        else
        {
            Console.WriteLine($"Book '{title}' is not in the collection.");
        }
    }

    // Limit Borrowing
    // Add a feature that tracks how many books a user has borrowed.
    // Limit the number of books to 3 at a time.
    public static List<Book> borrowedBooks = new List<Book>();

    public static void BorrowBook(string title, List<Book> books)
    {
        if (borrowedBooks.Count >= 3)
        {
            Console.WriteLine("Borrowing limit reached. Return a book before borrowing another.");
            return;
        }

        var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            if (book.IsCheckedOut)
            {
                Console.WriteLine($"Book '{title}' is already checked out.");
            }
            else
            {
                book.IsCheckedOut = true;
                borrowedBooks.Add(book); // Track borrowed book
                Console.WriteLine($"Book '{title}' has been checked out.");
            }
        }
        else
        {
            Console.WriteLine($"Book '{title}' not found in the library.");
        }
    }

    //Check-in a borrowed book
    // Add a feature that enables the user to check in a book that’s been checked out.
    // Check If the book is checked out. If it is remove the checked-out flag to check the book in.
    //  If it isn’t, inform the user.
    public static void CheckInBook(string title, List<Book> books)
    {
        var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            if (book.IsCheckedOut)
            {
                book.IsCheckedOut = false;
                Console.WriteLine($"Book '{title}' has been checked in successfully.");
            }
            else
            {
                Console.WriteLine($"Book '{title}' is not checked out.");
            }
        }
        else
        {
            Console.WriteLine($"Book '{title}' not found in the library.");
        }
    }

}

public class Book {
    public string Title { get; set; }
    public bool IsCheckedOut { get; set; }
    // Constructor to initialize the book with a title and set IsCheckedOut to false

    public Book(string title)
    {
        Title = title;
        IsCheckedOut = false;

    }
}
