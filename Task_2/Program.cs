Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int numC = Convert.ToInt32(Console.ReadLine());

int Max = numA;
if (numB > Max)
{
    Max = numB;
}
if (numC > Max)
{
    Max = numC;
}
Console.WriteLine("Max = " + Max);
