/* Задача 65. 
Задайте знаяени M и N.
Выведите все натуральный числа от M до N.
*/


Console.WriteLine("Введите целое число от:");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число до:");
int maxNumber = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(minNumber, maxNumber);


void NaturalNumbers (int min, int max)
{
    if (max == min - 1) return;
    NaturalNumbers(min, max - 1);
    Console.Write($"{max} ");
}