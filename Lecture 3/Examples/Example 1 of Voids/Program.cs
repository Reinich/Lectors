void Method1()                           // Первый метод, ничего не принимает, ничего не возвращает. Просто выполняет некоторые действия
{
    Console.WriteLine("Автор Ирина");
}
Method1();






void Method2(string msg)                 // Второй метод, принимает значение, но не возвращает его. Просто выполняет действия
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");




void Method21(string msg, int count)          // Тот же второй метод, вид сбоку
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст сообщения", count: 4); // Явно указывается какие переменные, которое должны быть переданы





int Method3()                               // Третий метод, возвращает переменные
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);






string Method4(int count, string text) // Четвертый метод, принимает и возвращает переменные (аргументы)
{                                      // Выделяем переменную, ПКМ, ринейм симбол = меняется везде эта переменная на новый текст
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");  // 10 - это count, "asdf" - это text. Можно менять их местами
Console.WriteLine(res);