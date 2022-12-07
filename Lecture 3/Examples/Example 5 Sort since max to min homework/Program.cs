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

void SelectionSort(int[] array)                                      // Сортировка массива от макс к мин
{

    for (int i = 0; i < array.Length - 1; i++)                       // Размер, как всегда, -1
    {
        int maxPosition = i;   // переменная в которую вкладывается первый (после - второй и тд) элемент для будущего сравнения

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;  // Сравнивание элемента с максимальным (на данный момент), запоминаем индекс

        }

        int temporary = array[i];                            // Пузырек!
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }

}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);