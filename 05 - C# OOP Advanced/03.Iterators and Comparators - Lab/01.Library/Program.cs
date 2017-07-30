using System;

public class Program
{
    public static void Main()
    {
        Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
        Book bookThree = new Book("The Documents in the Case", 2002);
        Book bookTwo = new Book("The Documents in the Case", 1930, "Dorothy Sayers", "Robert Eustace");
        
        Library library = new Library(bookOne, bookTwo, bookThree);

        foreach (var book in library)
        {
            Console.WriteLine(book);
        }
    }
}