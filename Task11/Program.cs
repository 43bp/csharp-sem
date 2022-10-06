// Выводит случайное число и удаляет вторую цифру этого числа

int DelSecDigit (int num)
{
    int firstD = num / 100;
    int trD = num % 10;
    int res = firstD * 10 + trD;
    return res;
}

int number = new Random().Next(100, 1000);
int del2D = DelSecDigit (number);
Console.WriteLine($"{number} => {del2D}");