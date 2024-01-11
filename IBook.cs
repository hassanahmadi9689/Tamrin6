namespace ConsoleApp82;

public  interface IBook
{
 public  void AddBook(string name,int price,int count,int type);
 public void RemoveBook(string name);
 public void ShowBooks();
}