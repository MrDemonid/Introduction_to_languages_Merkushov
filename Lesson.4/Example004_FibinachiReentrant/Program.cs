/*
    Фибоначи.
    f(n) = f(n-1) + f(n-2), при n >= 3;
    f(1) = f(2) = 1
*/

using System.Diagnostics;


/*
    рекурсивная версия
    Время выполнения приблизительно оценивается как O( ((1+sqrt(5))/2)^N )
*/
int FibonachiReentrant(int n)
{
    if (n > 2)
    {
        return FibonachiReentrant(n-1) + FibonachiReentrant(n-2);
    }
    return 1;   // строго говоря при N==0 нужно возвращать ошибку
}

/*
    моя версия, без рекурсии
*/
int Fibonachi(int n)
{
    int fn1;    // f(n-1)
    int fn2;    // f(n-2)
    int fn;     // f(n)
    
    fn1 = 1;    // f(-1)
    fn  = 0;    // f(0)
    for (int k = 1; k <= n; k++)
    {
        // продвижение вперёд на один член ряда
        fn2 = fn1;
        fn1 = fn;
        fn = fn1 + fn2;             // f(n) = f(n-1)+f(n-2)
    }
    return fn;
}

 Stopwatch stopwatch = new Stopwatch();
 long time_cycle;
 long time_reentrant;

int num_iteration;

do {
    Console.Clear();
    Console.WriteLine("Enter the number of iterations: ");
    num_iteration= Convert.ToInt32(Console.ReadLine());
} while (num_iteration < 2);

Console.WriteLine("CYCLE METHOD");
//засекаем время начала операции
stopwatch.Start();
Console.WriteLine($"f({num_iteration}) = {Fibonachi(num_iteration)}");
stopwatch.Stop();
time_cycle = stopwatch.ElapsedMilliseconds;

Console.WriteLine("REENTRANT METHOD...");
//засекаем время начала операции
stopwatch.Start();
    Console.WriteLine($"f({num_iteration}) = {FibonachiReentrant(num_iteration)}");
stopwatch.Stop();
time_reentrant = stopwatch.ElapsedMilliseconds;

Console.WriteLine($"Cycle method    : {time_cycle} msec");
Console.WriteLine($"Reentrant method: {time_reentrant} msec");
//Console.WriteLine("Press any key to exit");
//Console.ReadLine();
