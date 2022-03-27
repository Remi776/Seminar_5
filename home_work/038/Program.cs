double[] array = new double[10];

void FillArray(double[] collection)
{
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(1, 11);
    }
}

void PrintArray(double[] collection)
{
    Console.WriteLine();
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
    Console.WriteLine();
}

void SortDown(double[] arr)
{
    int maxIndex = 0;
    double temp = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        maxIndex = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxIndex]) maxIndex = j;
        }
        temp = arr[i];
        arr[i] = arr[maxIndex];
        arr[maxIndex] = temp;
    }
    double diff = 0;
    diff = arr[0] - arr[arr.Length - 1];
    PrintArray(array);
    Console.WriteLine($"max = {arr[0]} , min = {arr[arr.Length - 1]}\n");
    Console.WriteLine("max - min = " + diff);
}

Console.WriteLine("\nMain array");
FillArray(array);
PrintArray(array);
Console.WriteLine("\nSorted array");
SortDown(array);
