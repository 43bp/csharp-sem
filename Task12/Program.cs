// Принимает на вход 2 числа
/// Выводит является ли 1 число кратным 2
// Если не кратное - выводит остаток
// 34, 5 -> не кратно, остаток 4
// 30, 5 -> кратно

int Ost (int num1, int num2)
{
    int ost = num1 % num2;
    return ost;
}
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int ost = Ost(number1, number2);
if (ost == 0) Console.WriteLine($"{number1}, {number2}  -> кратно");
else Console.WriteLine($"{number1}, {number2}  -> не кратно, остаток {ost}");
