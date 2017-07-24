namespace _01.Library
{
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookThree = new Book("The Documents in the Case", 2002);
            Book bookTwo = new Book("The Documents in the Case", 1930, "Dorothy Sayers", "Robert Eustace");

            IList<Book> books = new List<Book>();
            books.Add(bookOne);
            books.Add(bookTwo);
            books.Add(bookThree);
        }
    }
}
