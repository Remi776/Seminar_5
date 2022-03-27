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

void Summ(int[] colection)
{
    int result = 0;
    int result_neg = 0;
    for (int i = 0; i < colection.Length; i++)
    {
        if (colection[i] > 0) result += colection[i];
        else result_neg += colection[i];
    }
    Console.WriteLine("\nСумма всех + цифр в массиве = " + result);
    Console.WriteLine("\nСумма всех - цифр в массиве = " + result_neg);
}

FillArray(array);
PrintArray(array);

Summ(array);