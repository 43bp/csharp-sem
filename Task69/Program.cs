/* Задача 69. 
Принимает два числа А и В
Возводит число А в степень В
*/

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целую степень:");
int degree = Convert.ToInt32(Console.ReadLine());
int numberDegree = NumberDegree (number, degree);
Console.WriteLine($"{number}, {degree} -> {numberDegree}");

int NumberDegree (int num, int deg)
{
    if (deg == 0) return 1;
    else return num * NumberDegree(num, deg - 1);
}