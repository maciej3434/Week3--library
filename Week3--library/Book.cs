class Book
{
    string title;
    string author;
    string isbn;

    void DisplayInfo()
    {
        Console.WriteLine($"Book title: {title}");
        Console.WriteLine($"Book Author: {author}");
        Console.WriteLine($"Book ISBN: {isbn}");
        Console.WriteLine();
    }

    static void Main(string[] args) 
    {
        // Instance of the Book class named 'book'
        Book book = new Book();

        // This information is for one book in our library
        book.title = "C# for beginners";
        book.author = "BillGates";
        book.isbn = "12345678";

        // Instance of the Book class named 'book1'
        Book book1 = new Book();
        book1.title = "C# Methods and classes";
        book1.author = "Microsoft";
        book1.isbn = "55667778";

        // Output book information to the console
        book.DisplayInfo();
        book1.DisplayInfo();
    }
}