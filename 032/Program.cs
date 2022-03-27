int[] array = new int[12];
Random rnd = new Random();

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(-9, 10);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
    Console.WriteLine("\n");
}

void Replace(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = -1 * collection[i];
    }
}

FillArray(array);
PrintArray(array);

Replace(array);
PrintArray(array);