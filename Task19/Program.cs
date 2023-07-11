// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckPolindrom(int number)
{
    if (number / 10000 == number % 10 & 
        number / 1000 % 10 == number / 10 % 10)
            Console.WriteLine("Это полиндром");
    else
        Console.WriteLine("Это не полиндром");
}

int GetImput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetImput("Введите пятизначное число: ");
CheckPolindrom(number);