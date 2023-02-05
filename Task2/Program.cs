// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5);

Random rnd = new Random();
int b1 = rnd.Next(-10, 10);
int k1 = rnd.Next(-10, 10);
int b2 = rnd.Next(-10, 10);
int k2 = rnd.Next(-10, 10);
double[] point = GetIntersectionPoint(b1, k1, b2, k2);

double[] GetIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] point = {x, y};

    return point;
}

System.Console.WriteLine($"{b1}, {k1}, {b2}, {k2} -> ({point[0]}; {point[1]})");