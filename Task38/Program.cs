// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = (new Random().Next(minValue, maxValue + 1)) + (new Random().NextDouble());    
    }
    return res;
}

int SearchMax(double[] array)
{
    int maxPosition = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if(array[i] > array[maxPosition]) maxPosition = i;
    }
    return maxPosition;
}

int SearchMin(double[] array)
{
    int minPosition = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if(array[i] < array[minPosition]) minPosition = i;
    }
    return minPosition;
}

void PrintArray(double[] array)
{
    Console.WriteLine("Заданный массив элементов:");
    int count = array.Length - 1;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]:f2},  ");
    }
    Console.Write($"{array[count++]:f2}");
    Console.WriteLine();
}

void PrintResult(double[] array, int indexMinNum, int indexMaxNum)
{
    double result = array[indexMinNum] + array[indexMaxNum];
    Console.WriteLine($"Значение минимального элемента равно {array[indexMinNum]:f2}");
    Console.WriteLine($"Значение максимального элемента равно {array[indexMaxNum]:f2}");
    Console.WriteLine($"Сумма максимального и минимального элемента равна {result:f2}");
}

void main()
{
    Console.Clear();
    double[] array = GetArray(10, 1, 100);
    int indexMaxNum = SearchMax(array);
    int indexMinNum = SearchMin(array);
    PrintArray(array);
    PrintResult(array, indexMinNum, indexMaxNum);
}

main();