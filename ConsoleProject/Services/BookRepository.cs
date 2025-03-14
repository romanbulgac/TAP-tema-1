using System;
using ConsoleProject.Models;
namespace ConsoleProject.Services;

public class BookRepository : IBookRepository
{
    List<LibraryItem> books = new List<LibraryItem>();
    public void Add(LibraryItem item)
    {
        books.Add(item);
    }
    public void Remove(LibraryItem item)
    {
        books.Remove(item);
    }
    public bool Contains(LibraryItem item)
    {
        return books.Contains(item);
    }

}
