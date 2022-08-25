Console.Write("Введите число 1 = "); 
int num1 = int.Parse(Console.ReadLine()); 
Console.Write("Введите число 2 = "); 
int num2 = int.Parse(Console.ReadLine());

if (num2 > num1)
{
    Console.WriteLine ("Из двух чисел большее число " + num2);
    Console.WriteLine ("а меньшее число " + num1);
}
else
{
    Console.WriteLine ("Из двух чисел большее число " + num1);
    Console.WriteLine ("а меньшее число " + num2);
}