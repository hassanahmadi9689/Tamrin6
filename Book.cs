namespace ConsoleApp82;

public abstract class Book
{
    protected Book(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public int Price { get; private set; }
    public int Count { get; private set; }

    public virtual void SetPrice(int price)
    {
        if (price < 0)
        {
            throw new Exception("price cant bee negative");
        }

        Price = price;
    }

    public virtual void SetCount(int count)
    {
        if (count < 0)
        {
            throw new Exception("count cant be negative");
        }

        Count = count;
    }
}

   
