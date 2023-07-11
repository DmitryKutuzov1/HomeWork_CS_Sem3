// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2) 
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return distance;
}

int GetImput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int xa = GetImput("Введите координату Х первого числа: ");
int ya = GetImput("Введите координату Y первого числа: ");
int za = GetImput("Введите координату Z первого числа: ");
int xb = GetImput("Введите координату Х второго числа: ");
int yb = GetImput("Введите координату Y второго числа: ");
int zb = GetImput("Введите координату Z второго числа: ");
Console.WriteLine("Расстояние = " + FindDistance(xa, ya, za, xb, yb, zb));