Console.Clear();
void FillArray(int[] collection)
{
    int length = collection.Length;
    int i = 0;
    while (i < length)
    {
        collection[i] = new Random().Next(1, 10);
        i++;
    }

}

void Print(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find) // файнд - это то, что мы напишем, когда будем вызывать функцию
{
    int count = collection.Length;
    int i = 0;
    int position = -1;
    while (i < count)
    {
        if (collection[i] == find)
        {
            position = i;
            break;
        }
        i++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
Print(array);
Console.WriteLine();
int pos = IndexOf(array, 4); // вот тут, мы вызываем функцию, коллекшион - это первый аргумент, 4 - это файнд, второй аргумент
Console.Write(pos);