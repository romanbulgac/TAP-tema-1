namespace ConsoleProject
{
    public interface ILibrarySystem
    {
        void AddBook(string book);
        void AddMember(string member);
        void BorrowBook(string member, string book);
        void ReturnBook(string member, string book);
    }
}
