using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Library
    {
        private List<Book> availableBooks;
        private Stack<Book> userOwnedBooks;

        public Library()
        {
            availableBooks = new List<Book>();
            userOwnedBooks = new Stack<Book>();
            // Initialize the library with some books
            InitializeLibrary();
        }

        private void InitializeLibrary()
        {
            availableBooks.Add(new Book("COOKING TO KILL: THE POISON COOK-BOOK", 1));
            availableBooks.Add(new Book("GALLOP YOUR MAGGOT: THE ULTIMATE BOOK OF SEXUAL SLANG", 2));
            availableBooks.Add(new Book("HOOKERS OR CAKE: ANIMAL SPIRITS, POP CULTURE, GOD AND ROBOTS", 3));
            availableBooks.Add(new Book("HOW TO COOK HUSBANDS", 4));
            availableBooks.Add(new Book("HOW TO ENJOY YOUR WEEDS", 5));
        }

        public void ListAllBooks()
        {
            Console.WriteLine("List of all books in the library:");
            foreach (var book in availableBooks)
            {
                Console.WriteLine($"Book name: {book.Name}\r\nBook no.: {book.BookNo}");
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        public void BorrowBook(string bookName)
        {
            // Initialize a variable to store the book to be borrowed
            Book bookToBorrow = null;

            // Loop through the available books one by one
            foreach (var book in availableBooks)
            {
                // Check if the book's name matches the requested book name
                if (string.Equals(book.Name, bookName, StringComparison.OrdinalIgnoreCase))
                {
                    // If a match is found, assign the book to the 'bookToBorrow' variable
                    bookToBorrow = book;
                    break; // Exit the loop because we found the book
                }
            }

            // Check if we found a book to borrow
            if (bookToBorrow != null)
            {
                // Remove the book from the available books list
                availableBooks.Remove(bookToBorrow);

                // Add the book to the user's owned books stack
                userOwnedBooks.Push(bookToBorrow);

                // Display a message confirming the successful borrowing
                Console.WriteLine($"You have borrowed the book: {bookToBorrow.Name}");
            }
            else
            {
                // If no matching book was found, display an error message
                Console.WriteLine("Book not found in the library.");
            }
        }

        public void ReturnBook(string bookName)
        {
            // Initialize a variable to store the book to be returned
            Book bookToReturn = null;

            // Loop through the user's owned books
            foreach (var book in userOwnedBooks)
            {
                // Check if the book's name matches the requested book name
                if (string.Equals(book.Name, bookName, StringComparison.OrdinalIgnoreCase))
                {
                    // If a match is found, assign the book to the 'bookToReturn' variable
                    bookToReturn = book;
                    break; // Exit the loop because we found the book
                }
            }

            // Check if we found a book to return
            if (bookToReturn != null)
            {
                // Remove the book from the user's owned books stack
                userOwnedBooks.Pop();

                // Add the book back to the available books in the library
                availableBooks.Add(bookToReturn);

                // Display a message confirming the successful return
                Console.WriteLine($"You have returned the book: {bookToReturn.Name}");
            }
            else
            {
                // If no matching book was found, display an error message
                Console.WriteLine("You don't own this book.");
            }
        }
    }
}
