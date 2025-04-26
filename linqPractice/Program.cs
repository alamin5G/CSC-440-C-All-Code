public class Program{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        Book book1 = new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", 2015, "Science Fiction");
        Book book2 = new Book(2, "To Kill a Mockingbird", "Harper Lee", 2018, "Science Fiction");
        Book book3 = new Book(3, "1984", "George Orwell", 2019, "Dystopian");
        Book book4 = new Book(4, "Pride and Prejudice", "Jane Austen", 2022, "Romance");
        Book book5 = new Book(5, "The Catcher in the Rye", "J.D. Salinger", 2017, "Science Fiction");
        Book book6 = new Book(6, "The Hobbit", "J.R.R. Tolkien", 2015, "Fantasy");

        books.Add(book1);
        books.Add(book2);  
        books.Add(book3);
        books.Add(book4);
        books.Add(book5);
        books.Add(book6);

        IEnumerable<Book> bookQuery = from book in books
            where book.YearPublished > 2015 && book.Genre == "Science Fiction"
            
            select book;

        Console.WriteLine("Books published after 2015 in the Science Fiction genre:");
        foreach (var book in bookQuery)
        {
            Console.WriteLine(book);
        }
    }
}