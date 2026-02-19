using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bl1 = new Book();
            bl1.title = "The White Tiger";
            bl1.pages = 304;
            bl1.price = 499;
            bl1.author = "Aravind Adiga";

            Console.WriteLine("Book One Details:");
            Console.WriteLine($"The Book Title is:{bl1.title}");
            Console.WriteLine($"This Book has Total of: {bl1.pages}");
            Console.WriteLine($"This Book price is {bl1.price}");
            Console.WriteLine($"The Author of the Book is {bl1.author}");

            Book bl2 = new Book();
            bl2.title = "The Room On The Roof";
            bl2.pages = 209;
            bl2.price = 499;
            bl2.author = "Ruskin Bond";
            Console.WriteLine("");
            Console.WriteLine("Book Two Details:");
            Console.WriteLine($"The Book Title is:{bl2.title}");
            Console.WriteLine($"This Book has Total of: {bl2.pages}");
            Console.WriteLine($"This Book price is {bl2.price}");
            Console.WriteLine($"The Author of the Book is {bl2.author}");
            Console.ReadLine();
        }
    }
    public class Book
    {
        public string title;
        public int pages;
        public int price;
        public string author;
    }

}

