// принимает на вход три числа и проверяет, 
// может ли существовать треугольник с такими сторонами
// теорема о неравенстве треугольника - каждая строна треугольника
// меньше суммы двух сторон

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (CheakTriangle(a, b, c)) Console.WriteLine("Треугольник с такими сторонами существует");
else Console.WriteLine("Треугольник с такими сторонами не существует");

// метод проверки треугольника
bool CheakTriangle (int a1, int a2, int a3)
{
    if (a1 < a2 + a3 && a2 < a1 + a3 && a3 < a1 + a2) return true;
    else return false;
}
