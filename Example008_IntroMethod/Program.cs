
Console.Clear();

int Max(int num1, int num2, int num3)
{
    int max = num1;
    if (num2 > max) max = num2;
    if (num3 >  max) max = num3;
    return max;
}
// int n1 = int.Parse(Console.ReadLine());
// int n2 = int.Parse(Console.ReadLine());
// int n3 = int.Parse(Console.ReadLine());

// int largest = Max(n1, n2, n3);

Console.WriteLine(Max(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));