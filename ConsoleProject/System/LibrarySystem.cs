using ConsoleProject.Models;
using ConsoleProject.Services;


namespace ConsoleProject.System;
public class LibrarySystem : ILibraryStorage, ILibraryLoanSystem
{
    private readonly IBookRepository bookRepository;
    private readonly IMemberRepository memberRepository;
    private readonly ILoanService loanService;


    public LibrarySystem(IBookRepository bookRepository, IMemberRepository memberRepository, ILoanService loanService)
    {
        this.bookRepository = bookRepository;
        this.memberRepository = memberRepository;
        this.loanService = loanService;
    }

    
    public void AddBook(LibraryItem book)
    {
        bookRepository.Add(book);
    }

    public void RemoveBook(LibraryItem book)
    {
        bookRepository.Remove(book);
    }

    public void AddMember(LibraryUser member)
    {
        memberRepository.Add(member);
    }

    public void BorrowBook(LibraryUser member, LibraryItem book)
    {
        if (bookRepository.Contains(book) && memberRepository.Contains(member))
        {
            loanService.BorrowItem(member, book);
            Console.WriteLine($"{member.Name} borrowed {book.Title}");
        }
        else
        {
            Console.WriteLine("Book or member not found.");
        }
    }

    public void ReturnBook(LibraryUser user, LibraryItem book)
    {
        loanService.ReturnItem(user, book);

    }


    public bool IsBookAvailable(LibraryItem book)
    {
        return loanService.IsItemAvailable(book);
    }

}
