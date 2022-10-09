// Программа, которая принимает на вход координаты двух точек
// находит расстояние между ними в 2D пространстве

// Будем использовать теорему пифагора и расстояние - это будет гипотенуза
// Так же узнаем оператор, который вычисляет корень

Console.WriteLine("Введите координаты первой точки");
Console.WriteLine("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.WriteLine("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya));
double resultD = Math.Round(result, 2);
Console.WriteLine($"A ({xa},{ya}); B ({xb},{yb}) -> {resultD}");