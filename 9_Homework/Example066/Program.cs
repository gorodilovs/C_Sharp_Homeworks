// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 4;
int n = 8;

int SumOfElements(int m, int n)
{
    if (n == m) return n;
    return n + SumOfElements(m, n - 1);
}

System.Console.WriteLine(SumOfElements(m, n));