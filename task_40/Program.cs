// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
//со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < 0 || b < 0 || c < 0)
{
    Console.WriteLine("Числа должны быть положительными ");
}
else if (a+b > c && a+c > b && b+c > a)
{
    Console.WriteLine("Треугольник существует со сторонами такой длины");
}
else
{
    Console.WriteLine("Треугольник  не существует со сторонами такой длины");
}
