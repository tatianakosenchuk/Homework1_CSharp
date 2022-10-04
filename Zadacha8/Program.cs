/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Enter number N");
int number = int.Parse(Console.ReadLine());

int x = 2;
Console.Write($"{number} -> ");
while (x <= number)
{
Console.Write($"{x}, ");
x = x + 2;
}

