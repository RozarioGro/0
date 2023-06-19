/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.Clear();
Console.WriteLine("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = GetCentrX(b1,k1,b2,k2);
double y = GetCentrY(b1,k1,b2,k2);
Console.WriteLine ($"({x:f1},{y:f1})");

double GetCentrX(double num1, double numb1, double num2, double numb2)
{
    double x = (num2-num1) / (numb1 - numb2);
    return x;
}

double GetCentrY(double num1, double numb1, double num2, double numb2)
{   
    double y = numb1 * x + num1;
    return y;
}





