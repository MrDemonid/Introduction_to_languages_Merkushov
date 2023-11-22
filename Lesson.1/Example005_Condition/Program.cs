Console.Write("Enter first name: ");

string username = Console.ReadLine();

if (username.ToLower() == "masha")        // ввод строки на русском почему-то не работает - всегда возвращает пустую строку!
{
    Console.WriteLine("Hurray, it's Masha!");
} else {
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
