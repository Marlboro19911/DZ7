// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int Promt(string? msg)
{
    System.Console.Write(msg + "-> ");
    return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int m = 4, int n = 4)
{
    Random rnd = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            array[i, x] = rnd.Next(15);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int x = 0; x < array.GetLength(1); x++)
        {
            System.Console.Write(array[i, x] + "; ");
        }
    }
}

bool CheckArray(int[,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            if (array[i, x] == num)
            {
                return true;
            }

        }
    }
    return false;
}

int[,] myArray = CreateArray();
PrintArray(myArray);
System.Console.WriteLine();
int number = Promt("Введите число");
System.Console.WriteLine(CheckArray(myArray, number));