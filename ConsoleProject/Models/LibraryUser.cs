using System;

namespace ConsoleProject.Models;

public abstract class LibraryUser
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    public LibraryUser(string name, string email, string phoneNumber, string address)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
    }
}
