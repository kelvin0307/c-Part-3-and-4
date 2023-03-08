using ConsoleApp2;

List<Book> books = new List<Book>();

while (true)
{
    Console.Write("Enter book title (or press Enter to finish): ");
    string title = Console.ReadLine();

    if (string.IsNullOrEmpty(title))
    {
        break;
    }

    Console.Write("Enter number of pages: ");
    int pages = int.Parse(Console.ReadLine());

    Console.Write("Enter publication year: ");
    int publicationYear = int.Parse(Console.ReadLine());

    Book book = new Book(title, pages, publicationYear);
    books.Add(book);
}

Console.Write("What do you want to print (everything or title)? ");
string input = Console.ReadLine();

if (input == "everything")
{
    foreach (Book book in books)
    {
        Console.WriteLine(book.Title+ " (" +book.Pages+ " pages, published in " +book.PublicationYear+ ")");
    }
}
else if (input == "title")
{
    foreach (Book book in books)
    {
        Console.WriteLine(book.Title);
    }
}