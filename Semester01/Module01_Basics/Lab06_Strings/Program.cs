// ---Гласные---

string text = "Программирование на C# — это увлекательно!";
int vowelCount = 0;

for (int i = 0; i < text.Length; i++)
{
    char c = text[i];

    switch (c)
    {
        case 'а':
        case 'А':
        case 'е':
        case 'Е':
        case 'ё':
        case 'Ё':
        case 'и':
        case 'И':
        case 'о':
        case 'О':
        case 'у':
        case 'У':
        case 'ы':
        case 'Ы':
        case 'э':
        case 'Э':
        case 'ю':
        case 'Ю':
        case 'я':
        case 'Я':
            vowelCount++;
            break;
        default:
           break;
    }
}
Console.WriteLine($"Гласных: {vowelCount}");

Console.WriteLine();

// ---Пробелы---

int spaceCount = 0;

for (int i = 0; i < text.Length; i++)
{
    char c = text[i];

    if(c == ' ')
    {
        spaceCount++;
    }
}
Console.WriteLine($"Пробелов: {spaceCount}");

Console.WriteLine();

// --- Методы, свойства типа string---

string raw = "   Hello, World!   ";
Console.WriteLine($"Исходная длина: {raw.Length}");

string rawTrim = raw.Trim();
Console.WriteLine($"Trim: [{rawTrim}]");

Console.WriteLine($"Длина после Trim: {rawTrim.Length}");

int indexOfRaw = rawTrim.IndexOf("World");
Console.WriteLine($"Индекс \"World\": {indexOfRaw}");

string rawSub = rawTrim.Substring(0, 5);
Console.WriteLine($"Substring(0, 5): [{rawSub}]");

Console.WriteLine($"Исходная после операций: [{raw}]");

