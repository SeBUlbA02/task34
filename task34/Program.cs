Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine()!);

int[] Array = getArray(length, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]");

findEven(Array);

int[] getArray(int size, int minValue, int maxValue)
{
    Random rnd= new Random();
    int[] result = new int[size];
    for(int i= 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void findEven(int[] MyArray)
{
    int even = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i]%2==0)
            even = even + 1;
    }
    Console.WriteLine($"Чётных чисел {even}");
}