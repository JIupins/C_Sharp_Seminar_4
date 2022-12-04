// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

void CreateCustomArray(int num)
{
    int[] Ary = new int[num];

    for (int i =0; i < Ary.Length; i++)
    {
        Ary[i] = new Random().Next(0,100);
    }

    Console.Write($"Сгенерирован произвольный массив из {num} элементов: ");
     foreach (int i in Ary)
    {
        Console.Write($"{i} ");
    }
}

Console.Write("Введите число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

CreateCustomArray(number);