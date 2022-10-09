// Программа принимает на вход номер четверти, 
// и по номеру четверти показывает диапазон возможных X и Y

string Сoordinates (string qc)
{
    if (qc == "1") return "x > 0; y > 0";
    if (qc == "2") return "x < 0; y > 0";
    if (qc == "3") return "x < 0; y < 0";
    if (qc == "4") return "x > 0; y < 0";
    return "Некорректный ввод";
}

Console.WriteLine("Введите номер четверти: ");
string q = Console.ReadLine();

string coordinates = Сoordinates(q);

Console.WriteLine(coordinates);