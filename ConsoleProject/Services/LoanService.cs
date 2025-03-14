using System;
using ConsoleProject.Models;

namespace ConsoleProject.Services;

public class LoanService : ILoanService
{
    Dictionary<LibraryUser, List<LibraryItem>> loanedItems = new Dictionary<LibraryUser, List<LibraryItem>>();
    List<LibraryItem> borrowedItems = new List<LibraryItem>();

    public void BorrowItem(LibraryUser user, LibraryItem item)
    {
        if (loanedItems.ContainsKey(user))
        {
            loanedItems[user].Add(item);
        }
        else
        {
            loanedItems.Add(user, new List<LibraryItem> { item });
        }
    }

    public bool IsItemAvailable(LibraryItem item)
    {
        return !borrowedItems.Contains(item);
    }

    public void ReturnItem(LibraryUser user, LibraryItem item)
    {
        if (loanedItems.ContainsKey(user) && loanedItems[user].Contains(item))
        {
            loanedItems[user].Remove(item);
            Console.WriteLine($"{user.Name} returned {item.Title}");
        }
        else 
        {
            Console.WriteLine("User has not borrowed this item");
        }
        borrowedItems.Remove(item);
    }

}
