
// See https://aka.ms/new-console-template for more information

using ConsoleApp82;
 IBook book = new Management();
while (true)
{
    try
    {
        Run();

    }
    catch (Exception exception)
    {
        ShowError(exception.Message);
    }
}


 void Run()
{var Option = GetNumberFromUser("Choose option:\n" +
                                "1.Add Book\n" +
                                "2.Remove Book\n" +
                                "3.show books" );
    switch (Option)
    {
        case 1:
        {
            
            var name = GetValidStringFromUser("enter name");
            var type = GetNumberFromUser("choose:\n1.sale book - 2.rental book");
            var price = GetNumberFromUser("enter price");
            var count = GetNumberFromUser("enter count");
            book.AddBook(name,price,count,type);
            
            break;
        }
        case 2:
        {
            var name = GetValidStringFromUser("enter name of book");
            book.RemoveBook(name);
            break;
        }
        case 3:
        {
            book.ShowBooks();
            break;
        }
       
    }
    
}


static string GetValidStringFromUser(string message)
{
    bool tryparse = false;
    string? value;
    do
    {
        Console.WriteLine(message);
        value = Console.ReadLine();
          
    } while ( string.IsNullOrWhiteSpace(value)   );
 
    return value;
}

static int GetNumberFromUser(string message)
{
    var resultTryParseFirstNumber = false;
    int number;
    do
    {
        Console.WriteLine(message);
        resultTryParseFirstNumber =
            int.TryParse(Console.ReadLine(), out number);
    } while (!resultTryParseFirstNumber );

    return number;
}

static void ShowError(string error)
{
    Console.WriteLine("*********");
    Console.WriteLine(error);
    Console.WriteLine("*********");
}