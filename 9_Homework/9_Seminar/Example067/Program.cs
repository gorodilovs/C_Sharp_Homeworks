// // Задача 67: Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int userNum = 455555;
int sum = 0;

int SumOfEachDigits(int number)
{
    
    if (number == 0) return 0;
    sum = number % 10 + SumOfEachDigits(number / 10);
    return sum;
}
System.Console.WriteLine(SumOfEachDigits(userNum));
