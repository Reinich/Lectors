Console.Clear();
// string Method4(int count, string text) // Выделяем переменную, ПКМ, ринейм симбол = меняется везде эта переменная на новый текст
// {
//     string result = String.Empty;

//     for (int i = 0; i<count; i++)
//     {
//         result = result+text;    
//     }
//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}