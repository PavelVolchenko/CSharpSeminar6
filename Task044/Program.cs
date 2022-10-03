/*  Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
    Первые два числа Фибоначчи: 0 и 1.
    Если N = 5 -> 0 1 1 2 3
    Если N = 3 -> 0 1 1
    Если N = 7 -> 0 1 1 2 3 5 8                                         */
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

int[] fibonacci(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        if (i == 0 || i == 1)
        {
            array[i] = i;
        }            
        else 
        {
            array[i] = array[i - 1] + array[i - 2];
        }
    }
    return array;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = fibonacci(number);
printArray(array, "Фибоначи");
