// // Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int m = 4;
int n = 8;

int Recursion(int numberStart, int numberEnd)
{
    if (numberEnd < numberStart) return numberStart;
    Recursion(numberStart, numberEnd - 1);
    System.Console.Write(numberEnd + " ");
    return numberEnd;
}
Recursion(m, n);