// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] Array(int size)
{
    int[] array = new int[size];
    return array;
}

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Неверное значение");             
        }  
        array[i] = value;
    }
    return array;
}

int FindPozitive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;        
    }
    return count;    
}

Console.WriteLine("Кол-во значений: ");
int size;
while (!int.TryParse(Console.ReadLine(), out size) || size == 0)
{
    Console.WriteLine("Неверное значение");            
}
Console.WriteLine("Введите значения через enter:");

Console.WriteLine($"Кол-во значений больше нуля: {FindPozitive(FillArray(Array(size)))}");