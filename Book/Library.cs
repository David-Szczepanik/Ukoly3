using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Book;
class Library {
    private List<Book> books = new List<Book>();
    public List<Book> Books {
        get { return books; }
        set { books = value; }
    }
    public void AddBook(Book b) {
        Books.Add(b);
        b.Available = true;
    }
    public void ListAvailable() {
        foreach(Book book in Books) {
            if(book.Available) {
                Console.WriteLine(book.ToString());
            }
        }
    }
    public void ListUnavailable() {
        foreach(Book book in Books) {
            if(!book.Available) {
                Console.WriteLine(book.ToString());
            }
        }
    }
    public void ListAll() {
        foreach(Book book in Books) {
            Console.WriteLine(book.ToString());
        }
    }
}
