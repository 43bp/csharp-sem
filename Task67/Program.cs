/* Задача 67. 
Принимать на вход число и возвращать сумму его цифр
*/

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(number);
Console.WriteLine($"{number} -> {sumNumbers}");


int SumNumbers(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumNumbers(num / 10);
}