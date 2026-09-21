public class Book{
    private int _pages;

    public string Title { get; }
    public string Author { get; }

    public int Pages
    {
        get => _pages;
        set        
        {
            if (value <= 0)
            {
                throw new ArgumentException("Page must be > 0");
            }   
            _pages = value;
         }
    }

    public Book(string title, string author, int pages)    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public override string ToString()
    {
        // return base.ToString();
        return $"Title: {Title}, Author: {Author}, Pages: {Pages}";
    }

    static void Main()
    {
        // Prompt for book title, author, and pages
        string title;
        string author;
        int pages;
        Console.Write("Enter book title: ");
        title = Console.ReadLine() ?? "";
        Console.Write("Enter book author: ");
        author = Console.ReadLine() ?? "";
        Console.Write("Enter pages in book:");
        pages = int.Parse(Console.ReadLine() ?? "");
        // Create a new Book using the values entered by user
        // BONUS CHALLENGE: handle exception and repeat until user enters correct values
        try
        {
             Book currentBook = new Book(title, author, pages);
            // Display the properties of the book
            Console.WriteLine($"Book info: {currentBook}"); // using .ToString() method

            // Console.WriteLine($"Title: {currentBook.Title}");
            // Console.WriteLine($"Author: {currentBook.Author}");
            // Console.WriteLine($"Pages: {currentBook.Pages}");
        } 
        catch(ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");    
        }
       
    }
}