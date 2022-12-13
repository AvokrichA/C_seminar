//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра введенного числа: {num/10%10}");


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет!");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine ("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Нет");
        break;
    case 2:
        Console.WriteLine("Нет");
        break;
    case 3:
        Console.WriteLine("Нет");
        break;
    case 4:
        Console.WriteLine("Нет");
        break;
    case 5:
        Console.WriteLine("Нет");
        break;
    case 6:
        Console.WriteLine("Да");
        break;
    case 7:
        Console.WriteLine("Да");
        break;                                
}
