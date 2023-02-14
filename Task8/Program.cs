// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите number: ");
int number = int.Parse(Console.ReadLine());
int n=1;
for (n = 1; n <= number; n++)
{
   if(n % 2 == 0)
   Console.Write($"{n}, ");
}


