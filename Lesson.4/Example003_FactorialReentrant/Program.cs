/*
    Найти факториал числа с помощью рекурсии
        factorial(n) = 1*2*3...*n
    или
        factorial(n) = n*...3*2*1

    например:
        factorial(5) = 5*4*3*2*1
    что можно представить как:
        factorial(5) = 5*factorial(4);

    то есть, если обобщить:
        factorial(n) = n * factorial(n-1)
*/

/*
    Чтобы не было переполнения, возвращаемое значение меняем на double
*/
double Factorial(int n)
{
    if (n > 1)
    {
        return n * Factorial(n-1);
    }
    return 1;   // 0! и 1! - равны 1
}


Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Factorial number '{num}' = {Factorial(num)}");
