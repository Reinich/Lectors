Console.Clear();

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)                // Вывести массив в одной строчке
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)                                      // Сортировка массива от мин к макс
{

    for (int i = 0; i < array.Length - 1; i++)                       // Размер, как всегда, -1
    {
        int minPosition = i;   // переменная в которую вкладывается элемент для будущего сравнения

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;  // Сравнивание элемента с минимальным (на данный момент), запоминаем его индекс

        }

        int temporary = array[i];                            // Пузырек!
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }

}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

