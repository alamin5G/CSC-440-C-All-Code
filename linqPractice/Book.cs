using System;
using System.Collections.Generic;

    public class Book
    {
     public int BookId { get; set; }
     public string Title { get; set; }
     public string Author { get; set; }
     public int YearPublished { get; set; }
    public string Genre { get; set; }

        public Book(int bookId, string title, string author, int yearPublished, string genre)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            YearPublished = yearPublished;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"BookId: {BookId}, Title: {Title}, Author: {Author}, YearPublished: {YearPublished}, Genre: {Genre}";
        }

}
