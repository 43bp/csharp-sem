// Программа принимает на вход число
// Выдаёт количество цифр в числе

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int quantity = Quantity (number);
Console.WriteLine($"Количество цифр в числе: {quantity}");

int Quantity (int num)
{
    int count = default;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}