
double rect1x1 = 4.5;
double rect1y1 = 2.3;
double rect1x2 = 8.2;
double rect1y2 = 4.9;

double area1 = Math.Abs((rect1x1 - rect1x2) * (rect1y1 - rect1y2));
Console.WriteLine($"Area of first rectangle is {area1}");

double rect2x1 = -3.2;
double rect2y1 = 1.1;
double rect2x2 = 3.7;
double rect2y2 = 5.6;

double area2 = Math.Abs((rect2x1 - rect2x2) * (rect2y1 - rect2y2));
Console.WriteLine($"Area of second rectangle is {area2}");

/* 
Area of first rectangle is 9,620000000000001
Area of second rectangle is 31,05
 */

Console.WriteLine($"Area of first rectangle with function is {AreaOfRectangle(rect1x1, rect1y1, rect1x2, rect1y2)}");

double AreaOfRectangle(double x1, double y1, double x2, double y2)
{

    // Implement AreaOfRectangle, such that it returns the area
    // of a rectangle defined by (x1, y1) and (x2, y2)
    double tempArea = Math.Abs((x1 - x2) * (y1 - y2));
    return tempArea;
}

Console.WriteLine($"Perimeter of pentagon is {perimeterOfPentagon(0, 0,
                                                                   4, 0,
                                                                   5, 3,
                                                                   2.5, 5,
                                                                   0, 3)}");


double perimeterOfPentagon(double x1, double y1,
                            double x2, double y2,
                            double x3, double y3,
                            double x4, double y4,
                            double x5, double y5)
{
    double lengthSide1 = calcLengthOfSide(x1, y1, x2, y2);
    double lengthSide2 = calcLengthOfSide(x2, y2, x3, y3);
    double lengthSide3 = calcLengthOfSide(x3, y3, x4, y4);
    double lengthSide4 = calcLengthOfSide(x4, y4, x5, y5);
    double lengthSide5 = calcLengthOfSide(x5, y5, x1, y1);

    double perimeter = lengthSide1 + lengthSide2 + lengthSide3 + lengthSide4 + lengthSide5;

    return perimeter;

}

double calcLengthOfSide(double x1, double y1, double x2, double y2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    Console.WriteLine(x + " " + y);
    double lengthSide = Math.Abs(Math.Sqrt(Math.Exp(x) + Math.Exp(y)));
    Console.WriteLine(lengthSide);

    return lengthSide;
}
