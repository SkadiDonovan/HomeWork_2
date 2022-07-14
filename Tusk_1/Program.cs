/* 
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа
*/
Console.WriteLine("Введите трехзначное число");
while (true)
{
    int number = int.Parse(Console.ReadLine());
    if (number > 99 && number < 1000)
    {
        int result = (number % 100) / 10;
        Console.WriteLine($"Вторым числом в {number} является число {result}");
        break;
    }
    Console.WriteLine("Вы ввели не корректное число. Введите трехзначное число");
}

