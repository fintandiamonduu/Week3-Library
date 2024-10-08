class Book
{
    //properties 
    string Title;
    string Author;
    string ISBN;
    int numOfPages;
    //constructors= for book object 
    //allows us to add a new instance to the book class 
    public Book(string bookTitle, string bookAuthor, string bookISBN, int booknumOfPages) 
    { 
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        numOfPages = booknumOfPages;
    }

    void DisplayInfo()
    {
        //output the book info to the console 
        Console.WriteLine("Book information");
        Console.WriteLine("...................");
        Console.WriteLine($"book title: {Title}");
        Console.WriteLine($"Author title: {Author}");
        Console.WriteLine($"ISBN number: {ISBN}");
        Console.WriteLine($"Number of pages: {numOfPages}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Book book = new Book("C# for begginers", "Bill Gates", "123456", 200);
        Book book2 = new Book("Visual studio 2022", "Microsoft", "134556", 70);

        // output book info to console 
        book.DisplayInfo();      
        book2.DisplayInfo();
    }
}