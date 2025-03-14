using ConsoleProject.Models;
using ConsoleProject.Services;
using ConsoleProject.System;
namespace ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client...");

            ILoanService loanService = new LoanService();
            IMemberRepository memberRepository = new MemberRepository();
            IBookRepository  bookRepository = new BookRepository();

            LibrarySystem library = new LibrarySystem(bookRepository, memberRepository, loanService);

            LibraryItem book1 = new Book("The Great Gatsby", "1234", "F. Scott Fitzgerald", "Fiction", 1925);
            LibraryItem book2 = new Book("Moby Dick", "5678", "Herman Melville", "Adventure", 1851);
            library.AddBook(book1);
            library.AddBook(book2);

            LibraryUser user1 = new Member("John Doe", "john.doe@mail.com","+123 012 123", "Romania, Iasi, bd. Carol I, 11");
            library.AddMember(user1);
            library.BorrowBook(user1, book1);
            library.ReturnBook(user1, book1);
            library.ReturnBook(user1, book1);
        }
    }
}
