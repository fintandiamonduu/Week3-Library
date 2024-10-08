class Book
{
    string Title;
    string Author;
    string ISBN;
    int numOfPages;

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
        //create a new instance of the book class 
        Book book = new Book();

        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "767269379";
        book.numOfPages = 200;

        Book book2 = new Book();
        book2.Title = "C# methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "3767620121";
        book2.numOfPages = 50;

        // output book info to console 
        book.DisplayInfo();
        book2.DisplayInfo();

      
    }
}