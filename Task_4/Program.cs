Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
int result;
while (count < (num + 1))
{
    result = count % 2;
    if (result == 0)
    {
        Console.Write(count + ", ");
    }
    count += 1;
}
