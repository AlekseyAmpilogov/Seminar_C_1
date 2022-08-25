Console.Write("Введите произвольное число = "); 
int num = int.Parse(Console.ReadLine()); 

if ((num % 2) ==0)
{
    Console.WriteLine ("Число " + num + " ЧЕТНОЕ");
}
else
{
        Console.WriteLine ("Число " + num + " НЕЧЕТНОЕ");
}
goto Start;