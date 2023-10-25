namespace Book;
class Book {
    private string title = "";
    private Author author;
    private int pages;
    private double price;
    private bool available;

    public string Title {
        get { return title; }
        set { title = value; }
    }
    public Author Author {
        get { return author; }
        set { author = value; }
    }
    public int Pages {
        get { return pages;}
        set { pages = value; }
    }
    public double Price {
        get { return price; }
        set { price = value; }
    }
    public bool Available {
        get { return available; }
        set { available = value; }
    }
    public Book(string title, Author author, int pages, double price, bool available) {
        Title = title;
        Author = author;
        Pages = pages;
        Price = price;
        Available = available;
    }
    public override string ToString() {
        return ($"{author.FirstName} {author.LastName}-{title}");
    }
}
