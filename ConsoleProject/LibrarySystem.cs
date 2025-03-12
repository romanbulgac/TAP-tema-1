namespace ConsoleProject
{
    // This class violates the Single Responsibility Principle (SRP) by handling multiple responsibilities.
    public class LibrarySystem : ILibrarySystem
    {
        private List<string> books = new List<string>();
        private List<string> members = new List<string>();

        // This method violates the Open/Closed Principle (OCP) because it requires modification to add new book types.
        public void AddBook(string book)
        {
            books.Add(book);
        }

        // This method violates the Liskov Substitution Principle (LSP) because it assumes all members are the same type.
        public void AddMember(string member)
        {
            members.Add(member);
        }

        // This method violates the Interface Segregation Principle (ISP) by forcing clients to implement methods they don't need.
        public void BorrowBook(string member, string book)
        {
            if (books.Contains(book) && members.Contains(member))
            {
                books.Remove(book);
                Console.WriteLine($"{member} borrowed {book}");
            }
            else
            {
                Console.WriteLine("Book or member not found.");
            }
        }

        // This method violates the Dependency Inversion Principle (DIP) by depending on concrete classes rather than abstractions.
        public void ReturnBook(string member, string book)
        {
            books.Add(book);
            Console.WriteLine($"{member} returned {book}");
        }
    }
}
