using System;
using ConsoleProject.Models;
namespace ConsoleProject.Services;

public class MemberRepository : IMemberRepository
{
    List<LibraryUser> users = new List<LibraryUser>();

    public void Add(LibraryUser user)
    {
        users.Add(user);
    }

    public bool Contains(LibraryUser user)
    {
        return users.Contains(user);
    }

    public void Remove(LibraryUser user)
    {
        users.Remove(user);
    }
}
