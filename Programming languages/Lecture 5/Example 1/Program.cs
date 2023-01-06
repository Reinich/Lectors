void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 99);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    Console.Write("Введите координаты: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (a > matrix.GetLength(0) || b > matrix.GetLength(1))
            {
                Console.WriteLine("Такой позиции нет");
                return;
            }
            else 
            {
                Console.WriteLine($"Значение элемента массива: {matrix[a - 1, b - 1]}");
                return;
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);