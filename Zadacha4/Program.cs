/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Enter number1");
int number1Ent = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number2");
int number2Ent = int.Parse(Console.ReadLine());
int number3Ent = int.Parse(Console.ReadLine());
int max = number1Ent;
if(number2Ent > max) max = number2Ent;
if(number3Ent > max) max = number3Ent;
Console.WriteLine ($"{number1Ent}, {number2Ent}, {number3Ent} = -> {max}");

