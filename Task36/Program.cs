// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);    
    }
    return res;
}

int GetSumm(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        res += array[i];
    }
    return res;
}

void PrintResult(int[] array, int count)
{
    Console.WriteLine($"В массиве ({String.Join(", ", array)}) сумма элементов, стоящих на нечетных позициях, равна {count}");
}

void main()
{
    int[] array = GetArray(10, -100, 100);
    int summCount = GetSumm(array);
    PrintResult(array, summCount);
}

main();