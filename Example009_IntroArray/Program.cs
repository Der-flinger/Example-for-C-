Console.Clear();

int[] array = {14,53,87,44,12,978,54,223,654};

int Max(int num1, int num2, int num3)
{
    int max = num1;
    if (num2 > max) max = num2;
    if (num3 >  max) max = num3;
    return max;
}

int max1 = Max(array[0], array[1], array[2]);
int max2 = Max(array[3], array[4], array[5]);
int max3 = Max(array[6], array[7], array[8]);

Console.WriteLine(Max(max1, max2, max3));