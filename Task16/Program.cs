// Принимает на вход 2 числа
// Проверяет, являетя ли одно число, квадратом другого
// 5,25 -> да
// 25,5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sq1 = number1 * number1;
int sq2 = number2 * number2;

if (sq1 == number2) Console.WriteLine($"{number1}, {number2} -> да");
else if (sq2 == number1) Console.WriteLine($"{number1}, {number2} -> да");
else Console.WriteLine($"{number1}, {number2} -> нет");