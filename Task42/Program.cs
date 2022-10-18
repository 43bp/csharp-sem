// преобразовывает десятичное в двоичное

Console.WriteLine("Введите десятичное число для конвертации в двоичное: ");
int number = Convert.ToInt32(Console.ReadLine());
int convertDecToBin = ConvertDecToBin(number);
Console.WriteLine(convertDecToBin);
string convertDecToBin2 = ConvertDecToBin2(number);
Console.WriteLine(convertDecToBin2);

// метод перевода десятичного числа в двоичное
int ConvertDecToBin (int num)
{
    int temp = 0;
    int count = 1;
    while (num != 0)
    {
       temp = temp + num % 2 * count;
       num = num / 2;
       count = count * 10;
    }
    return temp;
}

// 2 метод перевода десятичного числа в двоичное
string ConvertDecToBin2 (int num)
{
    string result = String.Empty;
    while (num != 0)
    {
       result = Convert.ToString(num % 2) + result;
       num = num / 2;
    }
    return result;
}
