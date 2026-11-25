Book[] library =
{
    new Book("Война и мир", "Л. Н. Толстой", 1869, 1225),
    new EBook("C# в действии", "Джон Скит", 2021, 850, 15.5),
    new Book("Мастер и Маргарита", "М. А. Булгаков", 1967, 480),
    new EBook("Чистый код", "Роберт Мартин", 2008, 464, 8.2),
};

foreach (Book b in library)
{
    b.PrintInfo();
    Console.WriteLine($"Современная: {(b.IsModern ? "ДА" : "НЕТ")}");
    Console.WriteLine();
}

Console.WriteLine("=== Только электронные книги ===");
foreach (Book b in library)
{
    if(b is EBook eb)
    {
        Console.WriteLine($"{eb.Title} - {eb.FileSizeMB} МБ");
    }
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
            if (value >= 1450 && value <= 2026)
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
            if (value > 0)
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


class EBook : Book
{
    private double _fileSizeMB;

    public double FileSizeMB
    {
        get
        {
            return _fileSizeMB;
        }
        set
        {
            if(value > 0)
            {
                _fileSizeMB = value;
            }
            else
            {
                throw new ArgumentException("Размер файла должен быть больше 0");
            }
        }
    }
    public EBook(string title, string author, int year, int pages, double fileSizeMB) : base(title, author, year, pages)
    {
        FileSizeMB = fileSizeMB;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Размер файла: {_fileSizeMB} МБ");
    }
}
