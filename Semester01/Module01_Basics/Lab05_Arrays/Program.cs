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
Console.Write($"Сумма(foreach): {sumForeach}");
