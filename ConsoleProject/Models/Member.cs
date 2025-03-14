using System;

namespace ConsoleProject.Models;

public class Member(string name, string email, string phoneNumber, string address) : LibraryUser(name,email, phoneNumber, address)
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
}
