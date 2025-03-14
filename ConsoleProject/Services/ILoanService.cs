using System;
using ConsoleProject.Models;

namespace ConsoleProject.Services;

public interface ILoanService
{
    void BorrowItem(LibraryUser user, LibraryItem item);
    void ReturnItem(LibraryUser user, LibraryItem item);    
    bool IsItemAvailable(LibraryItem item);
}   
