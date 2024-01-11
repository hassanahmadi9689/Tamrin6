namespace ConsoleApp82;

public class Management : IBook
{

    private List<Book> _books = new List<Book>();

    public void AddBook(string name, int price, int count, int type)
    {
        if (type==1)
        {
            var salebook = new SaleBook(name);
            salebook.SetPrice(price);
            salebook.SetCount(count);
            _books.Add(salebook);
        }

        if (type==2)
        {
            var rentalbook = new RentBook(name);
            rentalbook.SetCount(count);
            rentalbook.SetPrice(price);
            _books.Add(rentalbook);
        }

        if (type >2 || type<1)
        {
            throw new Exception("wrong type");
        }
    }

    public void RemoveBook(string name)
    {
        var book = _books.Find(_ => _.Name == name);
        if (book is null)
        {
            throw new Exception("book not found");
        }

        _books.Remove(book);
    }

    public void ShowBooks()
    {
        foreach (var book in _books)
        {
            Console.WriteLine($"name:{book.Name} - price:{book.Price} - count:{book.Count}");
        }
    }
}