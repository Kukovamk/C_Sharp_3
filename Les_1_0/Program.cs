// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли он палиндромом.

string Palindrom(int n)
{
    int num = 10000;
    if (n > 100000 && n < 10000)
        return "Это не пятизначное число!";
    else
        while (num > 1)
        {
            if (n / num % 10 != n % 10)
                return "Не палиндром";
            n = n / 10;
            num = num / 100;
        }
    return "Это палиндром";
}

Console.WriteLine(Palindrom(int.Parse(Console.ReadLine()!)));


