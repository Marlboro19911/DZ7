// Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EnterNumber(string msg)
{
    System.Console.WriteLine(msg + ">");
    return Convert.ToDouble(System.Console.ReadLine());
}

bool Validate(double k1, double k2)
{
    if (k1 == k2)
    return true;
    else return false;
} 

double findX (double b1,double b2,double k1,double k2)
{
    return (b2-b1)/(k1-k2);
}

double findY (double x, double b1,double k1)
{
    return k1*x+b1;
}

double b1 = EnterNumber("Введите точку b1");
double b2 = EnterNumber("Введите точку b2");
double k1 = EnterNumber("Введите точку k1");
double k2 = EnterNumber("Введите точку k2");
double X = findX (b1,b2,k1,k2);
double Y = findY (X,b1,k1);
if (Validate (k1, k2))
{
    System.Console.WriteLine("Прямые параллельны или совпадают");
}
else 
{
    System.Console.WriteLine($"Прямые пересекаются в точке {X}, {Y}");
}
