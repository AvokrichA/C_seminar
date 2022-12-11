int b = 1;
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
for (b % 2==0; b < a; b ++)
{
    Console.WriteLine(b);
    if (b == a)
    break;
}