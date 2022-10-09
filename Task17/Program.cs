// Программа принимает на вход координаты точки (X и Y), 
// причем X и Y не равны нулю,
// и выдает номер четверти в системе ординат, где эта точка находится

int Quarter (int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты точки");
Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter (x, y);

string result = quarter > 0 ? $"Указанные координаты соответствуют четверти  - {quarter}"  // Вот так можно задавать строку с логикой и впоследйющем ее выводить. 
                            : "Введены некорректные координаты";  // ? - это типа if. : - это типа else

Console.WriteLine(result);