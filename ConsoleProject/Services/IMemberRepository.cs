using System;
using ConsoleProject.Models;
namespace ConsoleProject.Services;
public interface IMemberRepository
{
    void Add(LibraryUser user);
    void Remove(LibraryUser user);
    bool Contains(LibraryUser user);
}
