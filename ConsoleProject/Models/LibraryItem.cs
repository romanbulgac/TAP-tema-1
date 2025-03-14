using System;
using ConsoleProject.Services;

namespace ConsoleProject.Models;

public abstract class LibraryItem
{
    public string Title { get; set; }
    public string Author {get; set; }
    public string ISBN { get; set; }

    public LibraryItem(string Title, string ISBN, string author){
        this.Title = Title;
        this.ISBN = ISBN;
        this.Author = author;
    }

}
