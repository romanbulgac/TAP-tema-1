namespace ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client...");

            // This code demonstrates a library system that violates SOLID principles.
            LibrarySystem library = new LibrarySystem();
            library.AddBook("The Great Gatsby");
            library.AddMember("John Doe");
            library.BorrowBook("John Doe", "The Great Gatsby");
            library.ReturnBook("John Doe", "The Great Gatsby");

            // Hints:
            // 1. SRP: Separate the responsibilities of managing books and members into different classes.
            // 2. OCP: Use inheritance or interfaces to allow adding new book types without modifying existing code.
            // 3. LSP: Ensure that derived classes can be substituted for their base classes without altering the correctness of the program.
            // 4. ISP: Split the LibrarySystem interface into smaller, more specific interfaces.
            // 5. DIP: Depend on abstractions (e.g., interfaces) rather than concrete classes.
        }
    }
}
