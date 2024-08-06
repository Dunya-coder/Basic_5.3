using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1:");
            Book k = new Book();
            k.Author = "Stive Jobs";
            k.BookName = "life experience ";
            k.Price = 79;
          
            k.print();
            Console.WriteLine("2 :");
            k.Author = "Jul Vern";
            k.BookName = "20,000 Leagues Under the Sea";
            k.Price = 9;
            k.print();

        }
    }
    class Book
    {

        private string bookname;//field
        private double price;
        private string author;

        public string BookName //property
        {
            get
            {
                return bookname;
            }
            set
            {
                bookname = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public double Price {
            get
            {
                return price;
            }
            set
            {
                if (price >= 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }
            }
        }
                    
               
        public Book()//Constructor
        {
            BookName = "No name";
            Author = "no";
            Price = 0;
        }
        public Book(string bookname, string author, double price)
        {
            BookName = bookname;
            Author = author;
            Price = price;
        }
        public  void print()
        {
            BookName = bookname;
            Author = author;
            Price = price;
            Console.WriteLine($"bookname:{BookName}\n author:{Author} \n price:{Price}");
        }
    }
}
