Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if(username?.ToLower() == "лола")
{
Console.WriteLine("Привет, моя хорошая!");
}
else 
{
Console.Write("Привет, ");
Console.WriteLine(username);
}