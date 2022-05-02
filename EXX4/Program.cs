// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Length(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double deltaX = Math.Abs(x1 - x2);
    double deltaY = Math.Abs(y1 - y2);
    double deltaZ = Math.Abs(z1 - z2);
    double deltaXYZ = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY)+ (deltaZ*deltaZ));
    return deltaXYZ;
}

double ax = 3;
double ay = 6;
double az = 8;
double bx = 2;
double by = 1;
double bz = -7;

Console.WriteLine("Длина " + Math.Round(Length(ax, ay, az, bx, by, bz), 2));