// Принимает на вход число N
// Выдает произведение чисел от 1 до N

Console.WriteLine("Введите число N: ");
long number = Convert.ToInt64(Console.ReadLine());

long factorial = Factorial (number);
Console.WriteLine($"Произведение чисел от 1 до {number}: {factorial}");


long Factorial (long num)
{
    long fact = 1;
    for (int i = 1; i <= num; i++)
    {
        checked // оператор проверки на переполение
        {
            fact = fact * i;
        }
    }
    return fact;
}
