// Виды методов

/*
    Вид 1
*/
void Method1()
{
    Console.WriteLine("view 1: void Method();");
}
Method1();

/*
    Вид 2
*/
void Method2(string msg)
{
    Console.WriteLine($"view 2: void Method({msg})");
}
Method2("param");

/*
    Вид 2 - именованные параметры
    можно явно задавать, какому аргументу какое значение присваиваем
*/
void Method21(string msg, int count)
{
    while (count > 0)
    {
        Console.WriteLine(msg);
        count--;
    }
}
// именованные параметры можно задавать в любом порядке
Method21(count: 4, msg: "Test 22");     


/*
    Вид 3
*/
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine("Year: " + year);


/*
    Вид 4
*/
string Method4(int count, string text)
{
    string result = String.Empty;
    while (count > 0)
    {
        result = result + text;
        count--;
    }
    return result;
}

string comp = Method4(4, "msg ");
Console.WriteLine("View 4 -> " + comp);
