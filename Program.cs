
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел."
               +  "Посчитайте, сколько чисел больше 0 ввёл пользователь."
               +  "0, 7, 8, -2, -2 -> 2 1, -7, 567, 89, 223-> 3");

Console.WriteLine("Нажмите Enter для продолжения...");
Console.ReadLine();

Console.Write("Введите количество элементов: ");
int m = Convert.ToInt32(Console.ReadLine());

int count = 0;
for (int i = 0; i < m; i++)
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
}

Console.Write("Количество чисел больше ноля: " + count);
Console.WriteLine("Нажмите Enter для продолжения...");
Console.ReadLine();
//////////


Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения"
                + "двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;"
                + "значения b1, k1, b2 и k2 задаются пользователем."
                + "b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");
               
Console.WriteLine("Нажмите Enter для продолжения...");
Console.ReadLine();
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine("Точка пересечения двух прямых: (" + x + " и " + y + ")");