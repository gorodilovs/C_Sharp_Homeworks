// // Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int n = 10;

int Recursion(int number)
{
    if (number < 1) return 1;
    Recursion(number - 1);
    System.Console.Write(number + " ");
    return number;
}
Recursion(n);