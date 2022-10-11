// Программа принимает на вход число А
// выдает сумму чисел от 1 до А
// 7 -> 28 (1+2+3+4+5+6+7)

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($"{number} -> {result}");

int SumNumbers (int num)
{
    int sum = default; // это то же, что и 0
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
       // sum += i // а можно и так... 
    }
    return sum;
}

int result = SumNumbers(number);
Console.WriteLine($"{number} -> {result}");
