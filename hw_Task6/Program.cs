// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число:");
int A = Convert.ToInt32(Console.ReadLine());

int digit = A % 2;

if(digit == 0)
{
    Console.WriteLine("да");
}
else Console.WriteLine("нет");