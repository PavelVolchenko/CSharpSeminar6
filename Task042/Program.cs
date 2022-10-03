/*  Задача 42: Напишите программу, которая будет преобразовывать 
    десятичное число в двоичное.
    45 -> 101101
    3 -> 11
    2 -> 10                                                     */

int convertToString(int number)
{
    int count = 1;
    int remains = number % 2;
    int temp = number / 2;
    int result = remains;
    Console.WriteLine(result);
    while (remains != 0)
    {
        remains = temp % 2;
        temp = temp / 2;
        count = count * 10;
        result += remains * count;
        Console.WriteLine(result);
    }
    return result;
}



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int bite = convertToString(number);
Console.Write(bite);
// string binaryCode = Convert.ToString(number, 2);
// Console.Write(binaryCode);