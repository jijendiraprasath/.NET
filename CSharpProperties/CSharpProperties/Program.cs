using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProperties
{
    internal class Program
    {
        public class Book
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


            class Program
            {
                static void Main(string[] args)
                {
                    Book Book1 = new Book();
                    Book1.Isbn = " 12345678910 ";
                    Book1.BookName = " CRIME DETERRENT ";
                    Book1.BookTitle = " CRIMENIL ";
                    Book1.BookAuthor = " Jije ";
                    Console.WriteLine("Enter Number of Books You Want Buy :");
                    Book1.QuantityOfBooks = int.Parse(Console.ReadLine());
                    Book1.BookPrice = 3999;
                    var TotalPrice = Book1.QuantityOfBooks * Book1.BookPrice;

                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" Book Details:");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" Isbn         | BookName          |  BookTitle | BookAuthor  | QuantityOfBooks | BookPrice  | Total Price");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(Book1.Isbn + " | " + Book1.BookName + " | " + Book1.BookTitle + " | " + Book1.BookAuthor + "      |      " + Book1.QuantityOfBooks + "          |     " + Book1.BookPrice + "   |    " + TotalPrice);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");


                }
            }
        }
    }
}
