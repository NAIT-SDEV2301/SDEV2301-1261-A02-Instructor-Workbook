Book first = new Book("Original");
Book alias = first;
alias.Title = "Changed through alias";
Console.WriteLine(first.Title);
class Book
{
    public string Title { get; set; }
    public Book(string title) { Title = title; }
}