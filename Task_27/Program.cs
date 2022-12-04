// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

void SumDigitsInNumber(int num)
{
    int result = 0;
    
    for (int count = Math.Abs(num); count > 0; count/=10)
    { 
        result += (count % 10);
    }

    Console.WriteLine($"Сума цифр в числе {num} равна {result}");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

SumDigitsInNumber(number);