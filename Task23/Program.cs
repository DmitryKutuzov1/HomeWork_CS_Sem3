// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void MakeCube(int n)
{
    int j = 0;       //Временная переменная, нужная для записи куба числа
    for (int i = 1; i < n; i++)
    {
        j = i * i * i;
        Console.Write(j + ", ");
    }
    Console.WriteLine(n * n * n);
}

int GetImput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetImput("Введите число больше 1: ");
MakeCube(number);