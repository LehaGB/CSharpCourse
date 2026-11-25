Book book1 = new Book("Война и мир", "Л. Н. Толстой", 1869, 1225);
Book book2 = new Book("C# в действии", "Джон Скит", 2021, 850);
Book book3 = new Book("Мастер и Маргарита", "М. А. Булгаков", 1967, 480);

book1.PrintInfo();
Console.WriteLine($"Современная: {(book1.IsModern ? "ДА" : "НЕТ")}");
Console.WriteLine();

book2.PrintInfo();
Console.WriteLine($"Современная: {(book2.IsModern ? "ДА" : "НЕТ")}");
Console.WriteLine();

book3.PrintInfo();
Console.WriteLine($"Современная: {(book3.IsModern ? "ДА" : "НЕТ")}");
Console.WriteLine();


Console.WriteLine("=== Проверка некорректных данных ===");

try
{
    Book badBook = new Book("Плохая книга", "Автор", 2020, -100);
    Console.WriteLine("ОШИБКА: исключение не сработало!");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Поймано исключение: {ex.Message}");
}

try
{
    Book badBook2 = new Book("Книга из будущего", "Автор", 3000, 100);
    Console.WriteLine("ОШИБКА: исключение не сработало!");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Поймано исключение: {ex.Message}");
}


public class Book
{
    private int _year;
    private int _pages;

    public string Title { get; }
    
    public string Author { get; }
  
    public int Year
    {
        get
        {
            return _year;
        }
        set
        {
            if(value >= 1450 && value <= 2026)
            {
                _year = value;
            }
            else
            {
                throw new ArgumentException("Год должен быть в диапазоне 1450..2026");
            }
        }
    }

    public int Pages
    {
        get
        {
            return _pages;
        }
        set
        {
            if(value > 0)
            {
                _pages = value;
            }
            else
            {
                throw new ArgumentException("Страниц должно быть больше 0");
            }
        }
    }

    public Book(string title, string author, int year, int pages)
    {
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;
    }


    public bool IsModern
    {
        get { return _year >= 2000; }
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Книга: «{Title}»");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Год: {_year}, страниц: {_pages}"); 
    }
}