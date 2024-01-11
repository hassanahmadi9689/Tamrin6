namespace ConsoleApp82;

public class SaleBook : Book
{
    public SaleBook(string name) : base(name)
    {
        
    }

    public override void SetCount(int count)
    {
        if (count>100)
        {
            throw new Exception("error");
        }
        base.SetCount(count);
    }

    public override void SetPrice(int price)
    {
        if (price > 10000)
        {
            throw new Exception("error");
        }

        base.SetPrice(price);
    }
}