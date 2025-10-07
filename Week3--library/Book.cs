namespace Library
{
    class Book
    {
        string title;
        string author;
        string isbn;

        public void DisplayInfo()
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
    }
}