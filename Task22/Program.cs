// Программа принимает на вход натуральное число
// выдает таблицу квадратов чисел jот 1 до N
// 5 -> 1,4,9,16,25
// 2 -> 1,4

void SqArray (int [] arr, int num)  // создаем метод void наполнения массива квадратом чисел от 1 до N
{
    int firstn = num - (num - 1); // вычисляем первое число, которое нужно возвести в квадрат
    int index = 0; // устанавливаем счетчик

    while (index < num)  // пока счетчик меньше нашего числа n (длины массива)
    {
        arr[index] = firstn * firstn;  // записываем в текущую позицию массива квадрат первого числа
        firstn++;  // переходиv ко следующему числу
        index++;  // также увеличиваем счетчик
    }
}

void PrintArray (int [] arrPr)  // создаем метод void печати элементов массива через запятую 
{
    int indexPrint = 0;   // вводим счетчик печати элементов массива
    int length = arrPr.Length;
    while (indexPrint < length)
    {
        Console.Write(arrPr[indexPrint]); // печатаем каждое число в одну строку через запятую
        indexPrint++; // увеличиваем счетчик
        if (indexPrint < length) Console.Write(", "); // говорим, пока счетчик меньше длины масива, печатай запятую (чтоб вконце запятая не ставилась)
    }
}

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n]; // создаем массив с числом элементов n (наше введеное число)

SqArray (array, n);
PrintArray (array);

