using System;
using ConsoleProject.Services;
namespace ConsoleProject.Models;

public class Book : LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    public Book(string title, string isbn, string author, string genre, int year): base(title, isbn, author)
    {
        Author = author;
        Genre = genre;
        Year = year;
    }
}
