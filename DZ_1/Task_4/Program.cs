Console.Write("Введите произвольное число = "); 
int N = int.Parse(Console.ReadLine());

Console.Write("Получим массив следующих четных чисел: ");

for (int i=1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(" " + i);
    }
}
