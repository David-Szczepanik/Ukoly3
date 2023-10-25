using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Book;

class Author {
    private string firstName = "";
    private string lastName = "";
    private List<Book> books = new List<Book>();
    private DateTime dateOfBirth;

    public string FirstName {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName {
        get { return lastName; }
        set { lastName = value; }
    }
    public DateTime DateOfBirth {
        get { return dateOfBirth; }
        set { dateOfBirth = value; }
    }
    public List<Book> Books {
        get { return books; }
        set { books = value; }
    }

    public Author(string firstName, string lastName, DateTime dateOfBirth) {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Books = new List<Book>();
    }

    public void ListBooks() {
        Console.WriteLine($"Books by {FirstName} {LastName}:");
        foreach(Book book in Books) {
            Console.WriteLine(book.Title);
        }

    }
    public override string ToString() {
        return ($"Jméno:{firstName} {lastName} {dateOfBirth:dd.MM.yyyy} ");
    }
}