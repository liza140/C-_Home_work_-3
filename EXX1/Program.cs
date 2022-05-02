// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

double Length(double x1, double y1, double x2, double y2)
{
    double deltaX = Math.Abs(x1 - x2);
    double deltaY = Math.Abs(y1 - y2);
    double deltaXY = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
    return deltaXY;
}

double ax = 7;
double ay = -5;
double bx = 1;
double by = -1;

Console.WriteLine("Длина " + Math.Round(Length(ax, ay, bx, by), 2));
