/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое целое число");
string number = Console.ReadLine()!;
int num = int.Parse(number);
Console.WriteLine("Введите второе целое число");
string number2 = Console.ReadLine()!;
int num2 = int.Parse(number2);
int max = num;

if (num > num2)
{
    Console.WriteLine(max = num);
}
else
{
    Console.WriteLine(max = num2);
}

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.WriteLine("Введите первое целое число");
string number = Console.ReadLine()!;
int num = int.Parse(number);
Console.WriteLine("Введите второе целое число");
string number2 = Console.ReadLine()!;
int num2 = int.Parse(number2);
Console.WriteLine("Введите третье целое число");
string number3 = Console.ReadLine()!;
int num3 = int.Parse(number3);
int max = num;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);
*/

/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
/*
Console.WriteLine("Введите число");
string number = Console.ReadLine()!;
int num = int.Parse(number);
bool check = num % 2 == 0;
Console.Write(check);
*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine()!;
int num = int.Parse(number);
int count = 1;

if (count == 1)
{
    count+=1;
}

while(count <= num)
{
    Console.Write(count + ", ");
    count +=2;
}