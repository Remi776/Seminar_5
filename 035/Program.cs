int[] array = new int[5];
Random rnd = new Random();

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(0, 200);
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

void Summ(int[] collection)
{
    int summ = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] >= 10 && collection[i] <= 99) summ += 1;
    }
    Console.WriteLine("Сумма = " + summ);
}

FillArray(array);
PrintArray(array);
Summ(array);