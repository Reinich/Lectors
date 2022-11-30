Console.Clear();

int[] array = { 11, 27, 31, 64, 35, 76, 27, 18, 95 };
int n = array.Length;
int find = 27;
int i = 0;

while (i < n)
{
    if (array[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    i++;
}