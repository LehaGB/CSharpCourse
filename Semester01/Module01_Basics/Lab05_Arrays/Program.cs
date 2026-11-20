int[] numbers = { 4, 8, 15, 16, 23, 42, 7, 3, 11, 9 };
int sumFor = 0;
for(int i = 0; i < numbers.Length; i++)
{
    sumFor += numbers[i];
}

Console.WriteLine($"Сумма(for): {sumFor}");

int sumForeach = 0;
foreach(int num in numbers)
{
    sumForeach += num;
}
Console.WriteLine($"Сумма(foreach): {sumForeach}");

Console.WriteLine();

// --- Минимум и максимум ---

int min = numbers[0];
int max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine($"Минимум: {min}");
Console.WriteLine($"Максимум: {max}");

Console.WriteLine();

// ---Чётные и нечётные ---

int evenCount = 0;
int oddCount = 0;

for (int i = 0; i <numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenCount++;
    }
    else
    {
        oddCount++;
    }
}
Console.WriteLine($"Чётные: {evenCount}");
Console.WriteLine($"Нечётные: {oddCount}");

Console.WriteLine();

// --- Обратный порядок ---.

Console.Write($"Обратный порядок: ");

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();
