/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/
Console.WriteLine("Напишите номер дня недели");

while (true)
{
    int number = int.Parse(Console.ReadLine());
    if (number > 0 && number < 8)
    {
        if (number <= 5)Console.WriteLine("Данный день недели не является выходным");
        else Console.WriteLine("Данный день недели является выходным");
    
        break;
    }
    Console.WriteLine("Вы ввели не корректное число. Введите число, обозначающее день недели");
}
