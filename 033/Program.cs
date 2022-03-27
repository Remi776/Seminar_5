int[] array = new int[8];
Random rnd = new Random();
int num = 0;

FillArray(array);
PrintArray(array);

if (Check(array)) Console.WriteLine(num + " есть");
else Console.WriteLine(num + " нет");

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

bool Check(int[] collection)
{
    Console.Write("Искомое число: ");
    num = rnd.Next(-9, 10);
    for (int i = 0; i < collection.Length; i++)
    {
        if (num == collection[i]) return true;
    }
    return false;
}