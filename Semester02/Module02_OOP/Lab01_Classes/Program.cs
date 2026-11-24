
Book book1 = new Book("Война и мир", "Л. Н. Толстой", 1869, 1225);
Book book2 = new Book("C# в действии", "Джон Скит", 2021, 850);
Book book3 = new Book("Мастер и Маргарита", "М. А. Булгаков", 1967, 480);

book1.PrintInfo();
Console.WriteLine($"Современная: {(book1.IsModern() ? "ДА" : "НЕТ")}");
Console.WriteLine();

book2.PrintInfo();
Console.WriteLine($"Современная: {(book2.IsModern() ? "ДА" : "НЕТ")}");
Console.WriteLine();

book3.PrintInfo();
Console.WriteLine($"Современная: {(book3.IsModern() ? "ДА" : "НЕТ")}");
Console.WriteLine();


public class Book
{
    private string _title;
    private string _author;
    private int _year;
    private int _pages;

    public Book(string title, string author, int year, int pages)
    {
        _title = title;
        _author = author;
        _year = year;
        _pages = pages;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Книга: «{_title}»");
        Console.WriteLine($"Автор: {_author}");
        Console.WriteLine($"Год: {_year}, страниц: {_pages}");
    }

     public bool IsModern()
     {
        return _year >= 2000;
     }
}
