int totalSeconds = 3725;
int hours = (totalSeconds / 3600);
int minutes = (totalSeconds % 3600) / 60;
int seconds = totalSeconds % 60;

Console.WriteLine($"Количество секунд {totalSeconds} = {hours} ч {minutes} мин {seconds} с");


string message = totalSeconds > 3600 ? "Это больше часа" : "Это меньше часа";
Console.WriteLine($"{message}");




