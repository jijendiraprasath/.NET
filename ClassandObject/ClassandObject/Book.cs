using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    internal class Book
    {
        public string Isbn;
        public string BookName;
        public string BookTitle;
        public string BookAuthor;
        public int QuantityOfBooks;
        public Double BookPrice;

        public string getIsbn()
        {
            return Isbn;
        }
        public string getBookName()
        {
            return BookName;
        }
        public string getBookTitle()
        {
            return BookTitle;
        }
        public string getBookAuthor()
        {
            return BookAuthor;
        }
        public int getQuantityOfBooks()
        {
            return QuantityOfBooks;
        }
        public Double getBookPrice()
        {
            return BookPrice;
        }
        public void setIsbn(string Isbn)
        {
            this.Isbn = Isbn;
        }
        public void setBooName(string BookName)
        {
            this.BookName = BookName;
        }
        public void setBookTitle(string BookTitle)
        {
            this.BookTitle = BookTitle;
        }
        public void setBookAuthor(string BookAuthor)
        {
            this.BookAuthor = BookAuthor;
        }
        public void setQuantityOfBooks(int QuantityOfBooks)
        {
            this.QuantityOfBooks = QuantityOfBooks;
        }
        public void setBookPrice(Double BookPrice)
        {
            this.BookPrice = BookPrice;
        }


        public class Program
        {
            public static void a4(string[] args)
            {
                Book Book1 = new Book();
                Book1.Isbn = " 92SW2-45H90 ";
                Book1.BookName = " Death Note ";
                Book1.BookTitle = " Inspirational Story ";
                Book1.BookAuthor = " nikhilvinay ";
                Console.WriteLine("ENter Number of Books You Want Buy :");
                Book1.QuantityOfBooks = int.Parse(Console.ReadLine());
                Book1.BookPrice = 1500;
                var TotalPrice = Book1.QuantityOfBooks * Book1.BookPrice;


                Console.WriteLine("Book Details:");
                Console.WriteLine("Isbn         | BookName        |   BookTitle          |BookAuthor  | QuantityOfBooks | BookPrice  | Total Price");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(Book1.Isbn + " | " + Book1.BookName + " | " + Book1.BookTitle + " | " + Book1.BookAuthor + " |      " + Book1.QuantityOfBooks + "          |     " + Book1.BookPrice + "   |    " + TotalPrice);


            }
        }
    }
}
