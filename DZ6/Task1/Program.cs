// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2     1, -7, 567, 89, 223-> 3

string Inputnumbers (string msg)
{
    System.Console.WriteLine($"{msg}");
    return System.Console.ReadLine();
}

int [] Splitstring (string numbers)
{
    string [] text = numbers.Split(" ");
    int [] array = new int [text.Length];
    for (int i = 0; i < text.Length; i++)
    {
       array [i] = Convert.ToInt32(text[i]);
    }
    return array;
}
int Findepossitive (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0 )
        {
            count ++;
        }

    }
    return count;
}
void Printarray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array [i] + " ");
    }
    System.Console.WriteLine();
}
string baseNumbers = Inputnumbers("Введите числа через пробел");
int [] resultArray = Splitstring(baseNumbers);
Printarray(resultArray);
int amoyntPossitive = Findepossitive(resultArray);
System.Console.WriteLine("Количество положительных чисел в массиве " + amoyntPossitive);

