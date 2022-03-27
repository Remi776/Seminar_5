int[] array = new int[10];

void FillArray(int[] collection)
{
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(100, 301);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
    Console.WriteLine();
}

void OddEvenCount(int[] colection)
{
    int count_even = 0;
    int count_odd= 0;
    for (int i = 0; i < colection.Length; i++)
    {
        if (colection[i] % 2 == 0) count_even += 1;
        else count_odd += 1;
    }
    Console.WriteLine("\nEven count = " + count_even);
    Console.WriteLine("\nOdd count = " + count_odd);
}

FillArray(array);
PrintArray(array);
OddEvenCount(array);