
PrintReport("qwerty");              // короткий, нет цифр, нет заглавных, нет спецсимволов
PrintReport("Qwerty123");           // длина 9, есть всё кроме спецсимвола
PrintReport("Qwerty123!");          // все правила выполнены
PrintReport("Пароль123!");          // кириллица — проверяем, что методы работают и с ней
PrintReport("!@#$%^&*");




bool HasMinLength(string p)
{
    return p.Length >= 8;
}


bool HasUpperCase(string p)
{
	for (int i = 0; i < p.Length; i++)
	{
		char c = p[i];

        if ((c >= 'А' && c <= 'Я') || (c >= 'A' && c <= 'Z'))
        {
            return true;
		}
	}
	return false;
}


bool HasLowerCase(string p)
{
    for (int i = 0; i < p.Length; i++)
    {
        char c = p[i];

        if((c >= 'а' && c <= 'я') || (c >= 'a' && c <= 'z'))
        {
            return true;
        }
    }
    return false;
}


bool HasDigit(string p)
{
	for (int i = 0; i < p.Length; i++)
	{
		char c = p[i];

		if(c >= '0' && c <= '9')
		{
            return true;
		}
	}
	return false;
}


bool HasSpecialChar(string p)
{
	for (int i = 0; i < p.Length; i++)
	{
		char c = p[i];

		if(c == '!' || c == '@' || c == '#' || c == '$' || c == '%' || c == '^' || c == '&' || c == '*')
		{
            return true;
		}
	}
	return false;
}


void PrintReport(string p)
{
    Console.WriteLine($"Пароль: [{p}]");
    Console.WriteLine($"Длина >= 8: {CheckingPasswordCondition(HasMinLength(p))}");
	Console.WriteLine($"Заглавная буква: {CheckingPasswordCondition(HasUpperCase(p))}");
	Console.WriteLine($"Строчная буква: {CheckingPasswordCondition(HasLowerCase(p))}");
	Console.WriteLine($"Цифра: {CheckingPasswordCondition(HasDigit(p))}");
	Console.WriteLine($"Спецсимвол: {CheckingPasswordCondition(HasSpecialChar(p))}");
    Console.WriteLine($"Итог: {(IsStrong(p) ? "НАДЁЖНЫЙ" : "СЛАБЫЙ")}");
    Console.WriteLine();
}


string CheckingPasswordCondition(bool s)
{
	if(s == true)
	{
       return "ДА";
    }
	else
	{
        return "НЕТ";
    }
}


bool IsStrong(string p)
{
    return HasMinLength(p)
        && HasUpperCase(p)
        && HasLowerCase(p)
        && HasDigit(p)
        && HasSpecialChar(p);
}


