// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(float, float, bool) FindCrossPoint (float b1, float k1, float b2, float k2) {
   float x = 0;
   float y = 0;
   bool parallel = false;
   if (!(k1 == k2))
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
    }
    else
    {
        Console.WriteLine($"Линии параллельны");
        parallel = true;
    }
    return (x, y, parallel);
}

Console.WriteLine("Введите b1");
float b1;
while (!float.TryParse(Console.ReadLine(), out b1))
{
    Console.WriteLine("Некорректное значение!");            
}
Console.WriteLine("Введите k1");
float k1;
while (!float.TryParse(Console.ReadLine(), out k1))
{
    Console.WriteLine("Некорректное значение!");            
}
Console.WriteLine("Введите b2");
float b2;
while (!float.TryParse(Console.ReadLine(), out b2))
{
    Console.WriteLine("Некорректное значение!");            
}
Console.WriteLine("Введите k2");
float k2;
while (!float.TryParse(Console.ReadLine(), out k2))
{
    Console.WriteLine("Некорректное значение!");            
}

(float x, float y, bool parallel) = FindCrossPoint(b1, k1, b2, k2);

if (!parallel) 
Console.WriteLine($"Точка пересечения: ({x}, {y})");


