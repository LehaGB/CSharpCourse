
PrintResults("Программирование на C# — это увлекательно!");
PrintResults("В 2026 году я выучу C# за 365 дней!");



int CountVowels(string s)
{
    int vowelCount = 0;

    for (int i = 0; i < s.Length; i++)
    {
        char c = s[i];

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
    return vowelCount;
}


int CountSpaces(string s)
{
    int spaceCount = 0;

    for (int i = 0; i < s.Length; i++)
    {
        char c = s[i];

        if (c == ' ')
        {
            spaceCount++;
        }
    }
    return spaceCount;
}


int CountDigits(string s)
{
    int countNumber = 0;

    for (int i = 0; i < s.Length; i++)
    {
        char c = s[i];

        if(c >= '0' && c <= '9')
        {
            countNumber++;
        }
    }
    return countNumber;
}

void PrintResults(string text)
{
    Console.WriteLine($"Текст: [{text}]");
    Console.WriteLine($"Гласных: {CountVowels(text)}");
    Console.WriteLine($"Пробелов: {CountSpaces(text)}");
    Console.WriteLine($"Цифр: {CountDigits(text)}");
    Console.WriteLine();  
}
