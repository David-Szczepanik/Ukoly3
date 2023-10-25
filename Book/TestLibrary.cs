using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book {
    internal class TestLibrary {
        static void Main(string[] args) {
            Author S_King = new Author("Stephen", "King",new DateTime(1947,9,21));
            Author G_Orwell = new Author("George", "Orwell", new DateTime(1903, 6, 25));
            Console.WriteLine("--Autor--");
            Console.WriteLine(S_King.ToString());
            Book b_Carrie = new Book("Carrie", S_King, 250, 300, true);
            Book b_1984 = new Book("1984", G_Orwell, 260, 250, true);
            //Console.WriteLine(b_Carrie.ToString());
            Console.WriteLine("\n--Dostupne--");
            Library library = new Library();

            library.AddBook(b_Carrie);
            library.AddBook(b_1984);


            Reader r1 = new Reader("Jan", "Novák", new DateTime(2000, 1, 1));

            library.ListAvailable();
            // Pujcit knihy vypis
            r1.BorrowBook(b_1984);
            Console.WriteLine("\n--Dostupne po pujceni--");
            library.ListAvailable();
            // Vypiste vsechny knihy
            Console.WriteLine("\n--Vypis vsech knih--");
            library.ListAll();
            // Vypiste aktualne dostupne
            Console.WriteLine("\nDostupne:");
            library.ListAvailable();
            // Nedostupne
            Console.WriteLine("\nNedostupne: ");
            library.ListUnavailable();
            

        }
    }
}
