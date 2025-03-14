using System;
using ConsoleProject.Services;
using ConsoleProject.Models;

namespace ConsoleProject.System;

public interface ILibraryLoanSystem
{
    void BorrowBook(LibraryUser user, LibraryItem item);
    void ReturnBook(LibraryUser user, LibraryItem item);
    bool IsBookAvailable(LibraryItem item);
}
