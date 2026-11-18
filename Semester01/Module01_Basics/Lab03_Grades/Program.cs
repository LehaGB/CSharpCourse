int score = 150;

if (score >= 90 && score <= 100)
{
    Console.WriteLine("Отлично");
}
else if (score >= 75 && score <= 89)
{
    Console.WriteLine("Хорошо");
}
else if (score >= 60 && score <= 74)
{
    Console.WriteLine("Удовлетворительно");
}
else if (score >= 0 && score <= 59)
{
    Console.WriteLine("Неудовлетворительно");
}
else
{
    Console.WriteLine("Некорректный балл");
}


char grade = 'X';

switch (grade)
{
    case 'A':
        Console.WriteLine("Превосходно");
        break;
    case 'B':
        Console.WriteLine("Хорошо");
        break;
    case 'C':
        Console.WriteLine("Средне");
        break;
    case 'D':
        Console.WriteLine("Слабо");
        break;
    case 'F':
        Console.WriteLine("Провал");
        break;
    default:
        Console.WriteLine("Неизвестная оценка");
        break;
}
