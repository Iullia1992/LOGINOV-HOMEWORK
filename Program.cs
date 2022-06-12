
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3 
int a = 5;
int b = 7;
if (b>a)
{
    Console.WriteLine(b);
}
else
{
    Console.WriteLine(a);
}
/*

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 
int a = 22;
int b = 3;
int c = 9;
int max = a;
if (b>max)
{
    max = b;
}
if (c>max)
{
    max = c;
}
Console.WriteLine(max); */

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). 
4 -> да
-3 -> нет
7 -> нет 

Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 0)
{
    Console.WriteLine("Да");
}  
else
{
    Console.WriteLine("Нет");
} */

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 2;
Console.WriteLine("Четные ");
while(sum<N)
{
    Console.Write(sum + " ");
    sum += 2;
} */