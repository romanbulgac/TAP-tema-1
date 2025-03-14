using System;
using ConsoleProject.Models;
namespace ConsoleProject.Services;
public interface IBookRepository
{
    void Add(LibraryItem item);
    void Remove(LibraryItem item);
    bool Contains(LibraryItem item);

}
