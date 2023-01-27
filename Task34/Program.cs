// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);    
    }
    return res;
}

bool EvenCheckRule(int elementArray)
{
    if(elementArray % 2 == 0) return true;
    else return false;
}

int CountElements(int[] ourArray)
{
    int count = 0;

    foreach(int elem in ourArray)
    {
        if (EvenCheckRule(elem)) count++;
    }

    return count;
}

void PrintResult(int[] array, int count)
{
    Console.WriteLine($"В массиве ({String.Join(", ", array)}) {count} чётных элементов");
}

void main()
{
    int[] array = GetArray(10, 100, 1000);
    int elementsCounted = CountElements(array);
    PrintResult(array, elementsCounted);
}

main();