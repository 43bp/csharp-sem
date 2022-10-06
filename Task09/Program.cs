// Выводит случайное число из отрезка [10,99]
// Показывает наибольшую цифру из числа

int number = new Random().Next(10,100); // 100 - потому что последнне значение не входит в диапазон и по факту будет 10 - 99
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");

//int firstdigit = number / 10;  // 78 /10 = 7 (целочисленное деление в int)
//int secdigit = number % 10;  // 78 % 10 - остаток будет 8.

//if (firstdigit == secdigit) Console.WriteLine($"Цифры числа {number} => равны");
//else if (firstdigit > secdigit) Console.WriteLine($"Наибольшая цифра числа {number} = {firstdigit}");
//else Console.WriteLine($"Наибольшая цифра числа {number} = {secdigit}");

int MaxDigit (int num)
{
int firstdigit = num / 10;
int secdigit = num % 10;
if (firstdigit > secdigit) return firstdigit;
return secdigit; // здесь нет необходимсоти в else так как после return (в предыдущей строке) код никуда не пойдет дальше

// int result = firstdigit > secdigit ? firstdigit : secdigit;
// return result; - а можно и в такой записи вместо if else (и необязательно с int, можно сразу через result)

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number} = {maxDigit}");