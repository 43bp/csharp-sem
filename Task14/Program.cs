// Принимает на вход число
// Проверяет кратно ли оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет
// 161 -> да

bool MpNum (int num0, int num1, int num2)
{
    return num0 % num1 == 0 && num0 % num2 == 0;
}

Console.WriteLine("Введите число: ");
int number0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число для проверки кратности: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для проверки кратности: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = MpNum (number0, number1, number2);
if (result) Console.WriteLine($"{number0} кратно одновремено {number1} и {number2}");
else Console.WriteLine($"{number0} не кратно одновремено {number1} и {number2}");