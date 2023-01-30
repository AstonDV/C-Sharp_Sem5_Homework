// Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);    
    }
    return res;
}

int InputArgumentSorting()
{
    Console.WriteLine("Каким образом вы хотите отсортировать массив?");
    Console.WriteLine($"1. Сортировка по возрастанию");
    Console.WriteLine($"2. Сортировка по убыванию");
    Console.Write("Выберите метод сортировки (1 или 2): ");
    int argumentSorting = int.Parse(Console.ReadLine()!);
    return argumentSorting;
}

int[] BubbleSort(int[] array, int argument)
{
    int temp;

    if(argument == 1)
    {
        for(int i = 0; i < array.Length; i++)
        {
            for(int j = 0; j < array.Length - i - 1; j++)
            {
                if(array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }
    else
    {
       for(int i = 0; i < array.Length; i++)
        {
            for(int j = 0; j < array.Length - i - 1; j++)
            {
                if(array[j] < array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array; 
    }
    
}

void PrintResult(int[] array)
{
    Console.WriteLine($"{String.Join(", ", array)}");
}

void main()
{
    Console.Clear();
    int[] array = GetArray(40, 0, 100);
    Console.WriteLine("Заданный массив:");
    PrintResult(array);
    int argument = InputArgumentSorting();
    if(argument != 1 && argument != 2)
    {
        Console.WriteLine("Ошибка! Введенного метода сортировки не существует!");
    }
    else
    {
        BubbleSort(array, argument);
        if (argument == 1) Console.WriteLine("Массив после сортировки по возрастанию:");
        else Console.WriteLine("Массив после сортировки по убыванию:");
        PrintResult(array);
    }
}

main();
