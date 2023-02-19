// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int Promt(string? msg)
{
    System.Console.Write(msg + "-> ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateArray(int m, int n)
{
    Random rnd = new Random();
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int x = 0; x < n; x++)
        {
            array[i, x] = rnd.Next(10);
        }
    }
    return array;
}

void Print(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
}

void PrintArray(double[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        System.Console.WriteLine();
        for (int x = 0; x < n; x++)
        {
            System.Console.Write(array[i, x] + "; ");
        }
    }
}

double[] SumArray(double[,] array, int m, int n)
{
    double sum = 0;
    double[] sumArray = new double[n];

    for (int i = 0; i < m; i++)
    {
        for (int x = 0; x < n; x++)
        {
            sum = sum + array[x, i];
            sumArray[i] = sum;
        }
        sum = 0;
    }
    System.Console.WriteLine("Сумма чисел в столбцах:");
    Print(sumArray);
    System.Console.WriteLine();
    return sumArray;
}

double[] AverageArray(double[] sumArray, int lengthColumn)
{
    double[] average = new double[lengthColumn];
    for (int i = 0; i < sumArray.Length; i++)
    {
        average[i] = sumArray[i] / lengthColumn;
    }
    System.Console.WriteLine("Среднее арифметическое каждого столбца:");
    return average;
}

bool Check(int lenghtString, int lengthColumn)
{
    if (lenghtString != lengthColumn)
    {
        System.Console.WriteLine("Строки и столбцы должны быть равны!");
        return true;
    }
    return false;
}

int ls = Promt("Введите продолжительность строк и столбцов");
int lc = ls;
Check(ls, lc);
double[,] myArray = CreateArray(ls, lc);
PrintArray(myArray, ls, lc);
System.Console.WriteLine();
System.Console.WriteLine();
double[] avr = AverageArray(SumArray(myArray, ls, lc), lc);
Print(avr);