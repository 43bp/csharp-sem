/* Задача 63. Задайте значение N.
Вывести все натуральные числа в промежутке от 1 до N.
N = 5 -> "1,2,3,4,5"
С помощью рекурсии!!!
*/

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number);


// рекурсивный метод (рекурсивный вызов в середине)
// печатаем элемент после рекурсивного вызова и числа будут в порядке возрастания
void NaturalNumbers (int num)
{
    if (num == 0) return; // прописываем условие выхода из рекурсии, когда дойдем до 0.
    NaturalNumbers(num - 1); // вызываем эту же функцию для предыдущего числа
    Console.Write($"{num} ");
}

/*
рекурсивный метод (хвостовая, так как рекурсивный вызов в конце)
при этом числа будут в обратном порядке
void NaturalNumbers (int num)
{
    if (num == 0) return; // прописываем условие выхода из рекурсии, когда дойдем до 0.
    Console.Write($"{num} ");
    NaturalNumbers(num - 1); // вызываем эту же функцию для предыдущего числа
}
*/