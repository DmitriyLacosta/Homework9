// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Программа, находит сумму натуральных чисел в промежутке от M до N.");

Console.Write("Введите число M = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N (должно быть больше M). N =  ");
int n = int.Parse(Console.ReadLine()!);

// рекурсия суммы чисел
int GetSum(int m, int n)
{
    if (m == n) return m;
    return m + GetSum(m + 1, n);
}

// проверка коректности ввода
if (m <= 0 && n <= 0) Console.WriteLine("Введенные числа должны быть положительными!");
else if (m > n)
    Console.WriteLine("Второе число должно быть больше первого!");
else
    Console.WriteLine($"Сумма чисел от {m} до {n} = {GetSum(m, n)}");

