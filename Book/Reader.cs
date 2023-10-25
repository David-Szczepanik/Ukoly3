using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Book;
class Reader {
    private string firstName = "";
    private string lastName = "";
    private List<Book> myBooks = new List<Book>();
    private DateTime dateOfBirth;
    public string FirstName {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName {
        get { return lastName; }
        set { lastName = value; }
    }
    public List<Book> MyBooks {
        get { return myBooks; }
        set { myBooks = value; }
    }
    public DateTime DateOfBirth {
        get { return dateOfBirth; }
        set { dateOfBirth = value; }
    }
    public Reader(string firstName, string lastName, DateTime dateOfBirth) {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
    public void BorrowBook(Book b) {
        if(b.Available == true) {
            myBooks.Add(b);
            b.Available = false;
        }
    }
    public void ReturnBook(Book b) {
        if(b.Available != true) {
            myBooks.Remove(b);
            b.Available = true;
        }
    }
    public void ListBorrowed() {
        foreach(Book book in myBooks) {
            Console.WriteLine(book.ToString());
        }
    }
}