/*
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
*/
Console.WriteLine("Введите число");

string number = Console.ReadLine();

char[] numberArray = number.ToCharArray();

if (numberArray.Length >= 3){
    Console.WriteLine($"Третим числом в {number} является число {numberArray[2]}");
} else {
    Console.WriteLine("Третьей цифры нет");
}
