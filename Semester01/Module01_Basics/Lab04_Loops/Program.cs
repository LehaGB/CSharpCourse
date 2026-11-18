// ---Часть 1---
int number = 7;

for (int i = 1; i <= 10; i++)
{
    int res = number * i;
    Console.WriteLine($"{number} * {i} = {res}");
}

// ---Часть 2---

int n = 101;

while (n % 13 != 0)
{
    n++;

}
Console.WriteLine($"{n}");

// ---Часть 3---

int secret = 7;
int attempt = 0;
int guess = 0;

do
{
    attempt++;
    guess = attempt * 2 - 1;
    

    if (guess == secret)
    {
        Console.WriteLine($"Угадал с попытки: {attempt}");
        break;
    }
    if (attempt >= 10)
    {
        Console.WriteLine($"не угадал");
        break;
    }

} while (attempt < 10);

