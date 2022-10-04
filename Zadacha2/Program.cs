/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Enter number1");
int number1Ent = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number2");
int number2Ent = int.Parse(Console.ReadLine());
if(number1Ent>number2Ent)
Console.WriteLine ($"a = {number1Ent} b = {number2Ent} = -> max = {number1Ent}");
else
{
Console.WriteLine ($"a = {number1Ent} b = {number2Ent} = -> max = {number2Ent}");
}