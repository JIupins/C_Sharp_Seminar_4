// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int EnterNumber(string word)
{
    Console.Write($"Введите число - {word}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void RaisingNumberToPower(int bas, int deg)
{
    int result = 1;

    for (int count = deg; count > 0; count--)
    {
        result *= bas;
    }
    Console.WriteLine($"{bas} в степени {deg} равно {result}");
}

int basis = EnterNumber("основание");
int degree = EnterNumber("степень");

RaisingNumberToPower(basis, degree);