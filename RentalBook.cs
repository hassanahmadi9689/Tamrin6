namespace ConsoleApp82;


    public class RentBook: Book
    {
        public RentBook(string name) :base(name)
        {
        
        }

        public override void SetPrice(int price)
        {
            if (price>500)
            {
                throw new Exception("price cant be bigger than 500");
            }
            base.SetPrice(price);
        }

        public override void SetCount(int count)
        {
            if (count>200)
            {
                throw new Exception("count cant be bigger than 200");
            }
            base.SetCount(count);
        }
    }
