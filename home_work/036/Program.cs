int[] array = new int[10];

void FillArray(int[] collection)
{
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(0, 11);
    }
}

void PrintArray(int[] collection)
{
    Console.WriteLine();
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
    Console.WriteLine();
}

void EvenSum(int[] colection)
{
    int count_odd= 0;
    for (int i = 1; i < colection.Length; i += 2)
    {
        count_odd += colection[i];
    }
    Console.WriteLine("\nThe sum with an odd number in the array = " + count_odd);
}

FillArray(array);
PrintArray(array);
EvenSum(array);