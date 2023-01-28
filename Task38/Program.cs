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
    int count = array.Length - 1;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]:f4}, ");
    }
    Console.Write($"{array[count++]:f4}");
    Console.WriteLine();
}

void PrintResult(double[] array, int indexMinNum, int indexMaxNum)
{
    // Console.WriteLine($"{String.Join(", ", array)}");    
    Console.WriteLine(array[indexMinNum]);
    Console.WriteLine(array[indexMaxNum]);
    Console.WriteLine(array[indexMinNum] + array[indexMaxNum]);
    Console.WriteLine($"{array[indexMinNum]:f4}");
}

void main()
{
    double[] array = GetArray(10, 1, 100);
    int indexMaxNum = SearchMax(array);
    int indexMinNum = SearchMin(array);
    PrintArray(array);
    PrintResult(array, indexMinNum, indexMaxNum);
}

main();