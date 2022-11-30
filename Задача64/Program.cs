// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Программа, выводит все натуральные числа в промежутке от N до 1");

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
int endValue = 1;

// проверка на отрицательный ввод
if (n < 0) Console.WriteLine("Некорректный ввод, введите натуральное число.");
else NumbersFromNToOne(n, endValue);

// рекурсия вывод чисел через запятую от N до 1
void NumbersFromNToOne(int n, int endValue)
{
    if (endValue < n)
    {
        NumbersFromNToOne(n, endValue + 1);
    }
    if (endValue > 1) Console.Write(endValue + ", ");
    else Console.Write(endValue);
}
