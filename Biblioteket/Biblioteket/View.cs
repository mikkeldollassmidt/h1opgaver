using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class View
    {
        public void Display()
        {
            Controller c = new Controller();
            Model m = new Model();

            while (true)
            {
                Console.Clear();
                MainMenu();
                c.MenuReadKey();
            }


        }
        public void MainMenu()
        {
            Console.WriteLine("Library Menu:");
            Console.WriteLine("1. List all books");
            Console.WriteLine("2. Borrow a book");
            Console.WriteLine("3. Return a book");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
        }
        public void BorrowBookMenu()
        {
            Library l = new Library();
            Console.Clear();
            Console.WriteLine("Write no.:\n");
            string userInput = Console.ReadLine();
            l.BorrowBook(userInput);
            Console.WriteLine("Book loaned!");
        }
        public void Library(List<Book> bl)
        {
            foreach (var book in bl)
            {
                Console.WriteLine($"Name: {book.Name} \n" +
                    $"Room number: {book.BookNo} \n");
            }
        }
    }
}


