int[] array = new int[8];

void FillArray(int[] collection)
{
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(1, 10);
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

void Product(int[] collection)
{
    for (int i = 0; i < collection.Length / 2 + collection.Length % 2; i++)
    {
        Console.Write(collection[i] * collection[collection.Length - i - 1] + " ");
    }
}

FillArray(array);
PrintArray(array);

Product(array);