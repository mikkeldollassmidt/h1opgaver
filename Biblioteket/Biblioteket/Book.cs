using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Book
    {
        private string _name;
        private byte _bookno;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public byte BookNo
        {
            get { return _bookno; }
            private set { _bookno = value; }
        }
        public Book()
        {

        }
        public Book(string name, byte bookno)
        {
            _bookno = bookno;
            _name = name;
        }
        List<Book> bl = new List<Book>();

        public void Library()
        {
            bl.Add(new Book("COOKING TO KILL: THE POISON COOK-BOOK", 1));
            bl.Add(new Book("GALLOP YOUR MAGGOT: THE ULTIMATE BOOK OF SEXUAL SLANG", 2));
            bl.Add(new Book("HOOKERS OR CAKE: ANIMAL SPIRITS, POP CULTURE, GOD AND ROBOTS", 3));
            bl.Add(new Book("HOW TO COOK HUSBANDS", 4));
            bl.Add(new Book("HOW TO ENJOY YOUR WEEDS", 5));
        }
        public void ListAllBooks(List<Book> books)
        {
            Console.WriteLine("List of all books in the library:");
            foreach (var book in books)
            {
                Console.WriteLine($"Book name: {book.Name}\r\nBook no.: {book.BookNo}");
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
