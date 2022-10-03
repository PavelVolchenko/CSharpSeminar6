/*  Задача 45: Напишите программу, которая будет создавать копию 
    заданного массива с помощью поэлементного копирования.    */

int[] generateArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
void printArray(int[] arrayToPrint, string name)
{
    System.Console.WriteLine($"-------------------{name}-------------------");
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine();
}

int[] copyIncomingArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int[] currentArray = generateArray(10, 10, 99);
printArray(currentArray, "Исходный массив");
int[] newArray = copyIncomingArray(currentArray);
printArray(newArray, "Копия исходного массива");