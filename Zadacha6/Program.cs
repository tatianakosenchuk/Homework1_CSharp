﻿/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine());
if (number%2 == 0)
Console.WriteLine ($"{number} => yes");
else 
Console.WriteLine ($"{number} => no");