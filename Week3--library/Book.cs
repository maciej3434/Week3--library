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

    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {
        title = bookTitle;
        author = bookAuthor;
        isbn = bookISBN;
    }
    static void Main(string[] args)
    {
        // Create a new book object
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        book.DisplayInfo();
    }
}