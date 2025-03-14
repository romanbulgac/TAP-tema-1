using ConsoleProject.Models;
namespace ConsoleProject.System;

public interface ILibraryStorage
{
    void AddBook(LibraryItem book);
    void RemoveBook(LibraryItem book);
}

